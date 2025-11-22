using AlmacenPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlmacenPF
{
    public partial class FormPedidos : Form
    {
        SistemaAlmacenContext context = new SistemaAlmacenContext();
        List<DetallePedidoView> listaDetalles = new List<DetallePedidoView>();

        public FormPedidos()
        {
            InitializeComponent();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cmbProveedor.DataSource = context.Proveedores.ToList();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "IdProveedor";

            cmbArticulo.DataSource = context.Articulos.ToList();
            cmbArticulo.DisplayMember = "Descripcion";
            cmbArticulo.ValueMember = "IdArticulo";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtCosto.Text))
            {
                MessageBox.Show("Ingrese cantidad y costo unitario.");
                return;
            }

            int idArticulo = (int)cmbArticulo.SelectedValue;
            var articuloSeleccionado = context.Articulos.Find(idArticulo);
            int cantidad = int.Parse(txtCantidad.Text);
            decimal costo = decimal.Parse(txtCosto.Text);

            var detalle = new DetallePedidoView
            {
                IdArticulo = idArticulo,
                NombreArticulo = articuloSeleccionado.Descripcion,
                Cantidad = cantidad,
                PrecioUnitario = costo,
                Subtotal = cantidad * costo
            };

            listaDetalles.Add(detalle);
            ActualizarGrid();
            txtCantidad.Text = "";
            txtCosto.Text = "";
            cmbArticulo.Focus();
        }

        private void ActualizarGrid()
        {
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = listaDetalles;

            decimal total = listaDetalles.Sum(x => x.Subtotal);
            lblTotal.Text = "Total: " + total.ToString("C2");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (listaDetalles.Count == 0)
            {
                MessageBox.Show("No hay artículos en el pedido.");
                return;
            }

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Pedido nuevoPedido = new Pedido();
                    nuevoPedido.Fecha = dtpFecha.Value;
                    nuevoPedido.IdProveedor = (int)cmbProveedor.SelectedValue;
                    nuevoPedido.TipoPedido = "Compra";
                    nuevoPedido.Estado = "Completado";

                    context.Pedidos.Add(nuevoPedido);
                    context.SaveChanges(); 

                    foreach (var item in listaDetalles)
                    {
                        DetallePedido det = new DetallePedido();
                        det.IdPedido = nuevoPedido.IdPedido;
                        det.IdArticulo = item.IdArticulo;
                        det.Cantidad = item.Cantidad;
                        det.PrecioUnitario = item.PrecioUnitario;

                        context.DetallePedidos.Add(det);

                        var art = context.Articulos.Find(item.IdArticulo);
                        art.Cantidad += item.Cantidad;
                        art.PrecioCompra = item.PrecioUnitario;
                    }

                    context.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Pedido guardado y stock actualizado exitosamente.");
                    listaDetalles.Clear();
                    ActualizarGrid();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }
    }

    public class DetallePedidoView
    {
        public int IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}