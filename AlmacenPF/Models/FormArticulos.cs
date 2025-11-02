using AlmacenPF.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AlmacenPF
{
    public partial class FormArticulos : Form
    {
        private SistemaAlmacenContext db = new SistemaAlmacenContext();

        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvArticulos.DataSource = db.Articulos
                .Select(a => new
                {
                    a.IdArticulo,
                    a.CodigoInterno,
                    a.CodigoBarras,
                    a.Descripcion,
                    a.Marca,
                    a.Cantidad,
                    a.PrecioCompra,
                    a.PrecioVenta
                })
                .ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevo = new Articulo
                {
                    CodigoInterno = txtCodigoInterno.Text,
                    CodigoBarras = txtCodigoBarras.Text,
                    Descripcion = txtDescripcion.Text,
                    Marca = txtMarca.Text,
                    Cantidad = int.Parse(txtCantidad.Text),
                    PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                    PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                    IdProveedor = null,
                    IdDistribuidor = null
                };


                db.Articulos.Add(nuevo);
                db.SaveChanges();
                MessageBox.Show("Artículo agregado correctamente.");
                CargarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nDetalle: " + ex.InnerException?.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                int id = (int)dgvArticulos.CurrentRow.Cells["IdArticulo"].Value;
                var art = db.Articulos.Find(id);

                if (art != null)
                {
                    art.CodigoInterno = txtCodigoInterno.Text;
                    art.CodigoBarras = txtCodigoBarras.Text;
                    art.Descripcion = txtDescripcion.Text;
                    art.Marca = txtMarca.Text;
                    art.Cantidad = int.Parse(txtCantidad.Text);
                    art.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
                    art.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);

                    db.SaveChanges();
                    MessageBox.Show("Artículo actualizado.");
                    CargarDatos();
                    LimpiarCampos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                int id = (int)dgvArticulos.CurrentRow.Cells["IdArticulo"].Value;
                var art = db.Articulos.Find(id);

                if (art != null)
                {
                    db.Articulos.Remove(art);
                    db.SaveChanges();
                    MessageBox.Show("Artículo eliminado.");
                    CargarDatos();
                    LimpiarCampos();
                }
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                txtCodigoInterno.Text = dgvArticulos.CurrentRow.Cells["CodigoInterno"].Value?.ToString();
                txtCodigoBarras.Text = dgvArticulos.CurrentRow.Cells["CodigoBarras"].Value?.ToString();
                txtDescripcion.Text = dgvArticulos.CurrentRow.Cells["Descripcion"].Value?.ToString();
                txtMarca.Text = dgvArticulos.CurrentRow.Cells["Marca"].Value?.ToString();
                txtCantidad.Text = dgvArticulos.CurrentRow.Cells["Cantidad"].Value?.ToString();
                txtPrecioCompra.Text = dgvArticulos.CurrentRow.Cells["PrecioCompra"].Value?.ToString();
                txtPrecioVenta.Text = dgvArticulos.CurrentRow.Cells["PrecioVenta"].Value?.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtCodigoInterno.Clear();
            txtCodigoBarras.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
        }
    }
}
