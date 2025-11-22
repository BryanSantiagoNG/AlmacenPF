using AlmacenPF.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AlmacenPF
{
    public partial class FormConsultaArticulos : Form
    {
        SistemaAlmacenContext context = new SistemaAlmacenContext();

        public FormConsultaArticulos()
        {
            InitializeComponent();
        }

        private void FormConsultaArticulos_Load(object sender, EventArgs e)
        {
            CargarTodo();
        }

        private void CargarTodo()
        {
            dgvArticulos.DataSource = context.Articulos.Select(a => new {
                a.CodigoInterno,
                a.CodigoBarras,
                Producto = a.Descripcion,
                a.Marca,
                Precio = a.PrecioVenta,
                Stock = a.Cantidad
            }).ToList();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();

            var filtro = context.Articulos
                .Where(a => a.Descripcion.ToLower().Contains(busqueda) ||
                            a.CodigoInterno.Contains(busqueda) ||
                            a.Marca.ToLower().Contains(busqueda))
                .Select(a => new {
                    a.CodigoInterno,
                    a.CodigoBarras,
                    Producto = a.Descripcion,
                    a.Marca,
                    Precio = a.PrecioVenta,
                    Stock = a.Cantidad
                }).ToList();

            dgvArticulos.DataSource = filtro;
        }
    }
}