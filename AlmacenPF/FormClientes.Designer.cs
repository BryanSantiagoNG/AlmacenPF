namespace AlmacenPF
{
    partial class FormClientes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvClientes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(30, 30); this.label1.Text = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(100, 27); this.txtNombre.Size = new System.Drawing.Size(200, 20);

            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(30, 60); this.label2.Text = "Teléfono:";
            this.txtTelefono.Location = new System.Drawing.Point(100, 57); this.txtTelefono.Size = new System.Drawing.Size(200, 20);

            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(30, 90); this.label3.Text = "Dirección:";
            this.txtDireccion.Location = new System.Drawing.Point(100, 87); this.txtDireccion.Size = new System.Drawing.Size(200, 20);

            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(30, 120); this.label4.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(100, 117); this.txtEmail.Size = new System.Drawing.Size(200, 20);

            this.btnGuardar.Text = "Guardar"; this.btnGuardar.Location = new System.Drawing.Point(330, 25); this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnEliminar.Text = "Eliminar"; this.btnEliminar.Location = new System.Drawing.Point(330, 55); this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnLimpiar.Text = "Limpiar"; this.btnLimpiar.Location = new System.Drawing.Point(330, 85); this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(30, 160);
            this.dgvClientes.Size = new System.Drawing.Size(500, 250);
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);

            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEmail); this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion); this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono); this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre); this.Controls.Add(this.label1);
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}