using System;
using System.Windows.Forms;

namespace AlmacenPF
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos frm = new FormArticulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuConsulta_Click(object sender, EventArgs e)
        {
            FormConsultaArticulos frm = new FormConsultaArticulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos frm = new FormPedidos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}