using AlmacenPF.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AlmacenPF
{
    public partial class FormClientes : Form
    {
        SistemaAlmacenContext context = new SistemaAlmacenContext();
        int idClienteSeleccionado = 0;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvClientes.DataSource = context.Clientes.ToList();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            idClienteSeleccionado = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            if (idClienteSeleccionado == 0)
            {
                Cliente c = new Cliente();
                c.Nombre = txtNombre.Text;
                c.Telefono = txtTelefono.Text;
                c.Direccion = txtDireccion.Text;
                c.Email = txtEmail.Text;
                context.Clientes.Add(c);
                MessageBox.Show("Cliente agregado.");
            }
            else
            {
                var c = context.Clientes.Find(idClienteSeleccionado);
                c.Nombre = txtNombre.Text;
                c.Telefono = txtTelefono.Text;
                c.Direccion = txtDireccion.Text;
                c.Email = txtEmail.Text;
                MessageBox.Show("Cliente actualizado.");
            }

            context.SaveChanges();
            Limpiar();
            CargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado != 0)
            {
                if (MessageBox.Show("¿Seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var c = context.Clientes.Find(idClienteSeleccionado);
                    context.Clientes.Remove(c);
                    context.SaveChanges();
                    Limpiar();
                    CargarGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvClientes.Rows[e.RowIndex];
                idClienteSeleccionado = (int)row.Cells["IdCliente"].Value;
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }
    }
}