using AlmacenPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AlmacenPF
{
    public partial class FormVentas : Form
    {
        SistemaAlmacenContext context = new SistemaAlmacenContext();
        List<DetalleFacturaView> carrito = new List<DetalleFacturaView>();

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dtpFecha.Value = DateTime.Now;
            cmbArticulos.SelectedIndexChanged += CmbArticulos_SelectedIndexChanged;
        }

        private void CargarDatos()
        {
            var clientes = context.Clientes.ToList();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "IdCliente";
            cmbClientes.SelectedIndex = -1;

            var articulos = context.Articulos.Select(x => new {
                x.IdArticulo,
                DescripcionCompleta = x.Descripcion + " - $" + x.PrecioVenta
            }).ToList();

            cmbArticulos.DataSource = articulos;
            cmbArticulos.DisplayMember = "DescripcionCompleta";
            cmbArticulos.ValueMember = "IdArticulo";
        }

        private void CmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedValue != null)
            {
                if (int.TryParse(cmbArticulos.SelectedValue.ToString(), out int idArticulo))
                {
                    var art = context.Articulos.Find(idArticulo);
                    if (art != null)
                    {
                        lblStock.Text = $"Stock Disponible: {art.Cantidad}";
                        lblStock.ForeColor = art.Cantidad < 5 ? System.Drawing.Color.Red : System.Drawing.Color.Blue;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedValue == null || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Seleccione un artículo y cantidad.");
                return;
            }

            int idArticulo = (int)cmbArticulos.SelectedValue;
            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            var articuloDB = context.Articulos.Find(idArticulo);

            if (articuloDB.Cantidad < cantidad)
            {
                MessageBox.Show($"No hay suficiente stock. Solo quedan {articuloDB.Cantidad}.");
                return;
            }

            var existente = carrito.FirstOrDefault(x => x.IdArticulo == idArticulo);
            if (existente != null)
            {
                if (articuloDB.Cantidad < (existente.Cantidad + cantidad))
                {
                    MessageBox.Show("Stock insuficiente para agregar más.");
                    return;
                }
                existente.Cantidad += cantidad;
                existente.Total = existente.Cantidad * existente.PrecioUnitario;
            }
            else
            {
                var detalle = new DetalleFacturaView
                {
                    IdArticulo = idArticulo,
                    Descripcion = articuloDB.Descripcion,
                    PrecioUnitario = articuloDB.PrecioVenta,
                    Cantidad = cantidad,
                    Total = cantidad * articuloDB.PrecioVenta
                };
                carrito.Add(detalle);
            }

            txtCantidad.Text = "";
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;
            lblTotalPagar.Text = "TOTAL: " + carrito.Sum(x => x.Total).ToString("C2");
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("Carrito vacío.");
                return;
            }

            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Factura nuevaFactura = new Factura
                    {
                        Fecha = DateTime.Now,
                        IdCliente = (int)cmbClientes.SelectedValue,
                        Total = carrito.Sum(x => x.Total)
                    };

                    context.Facturas.Add(nuevaFactura);
                    context.SaveChanges();

                    foreach (var item in carrito)
                    {
                        DetalleFactura det = new DetalleFactura
                        {
                            IdFactura = nuevaFactura.IdFactura,
                            IdArticulo = item.IdArticulo,
                            Cantidad = item.Cantidad,
                            PrecioUnitario = item.PrecioUnitario
                        };
                        context.DetalleFacturas.Add(det);

                        var artDb = context.Articulos.Find(item.IdArticulo);
                        artDb.Cantidad -= item.Cantidad;
                    }

                    context.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Venta realizada con éxito.");
                    carrito.Clear();
                    ActualizarGrid();
                    CargarDatos();
                    lblStock.Text = "Stock Disponible: --";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }

    public class DetalleFacturaView
    {
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
    }
}