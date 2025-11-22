namespace AlmacenPF
{
    partial class FormPedidos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Text = "Proveedor:";

            // cmbProveedor
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(100, 27);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(250, 21);

            // label2 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 30);
            this.label2.Name = "label2";
            this.label2.Text = "Fecha:";

            // dtpFecha
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(450, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 20);

            // grpDetalles
            this.grpDetalles.Controls.Add(this.btnAgregar);
            this.grpDetalles.Controls.Add(this.txtCosto);
            this.grpDetalles.Controls.Add(this.label5);
            this.grpDetalles.Controls.Add(this.txtCantidad);
            this.grpDetalles.Controls.Add(this.label4);
            this.grpDetalles.Controls.Add(this.cmbArticulo);
            this.grpDetalles.Controls.Add(this.label3);
            this.grpDetalles.Location = new System.Drawing.Point(30, 70);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(700, 80);
            this.grpDetalles.Text = "Agregar Artículo";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Text = "Artículo:";

            // cmbArticulo
            this.cmbArticulo.Location = new System.Drawing.Point(70, 27);
            this.cmbArticulo.Size = new System.Drawing.Size(250, 21);

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 30);
            this.label4.Text = "Cant:";

            // txtCantidad
            this.txtCantidad.Location = new System.Drawing.Point(370, 27);
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);

            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 30);
            this.label5.Text = "Costo Unit:";

            // txtCosto
            this.txtCosto.Location = new System.Drawing.Point(510, 27);
            this.txtCosto.Size = new System.Drawing.Size(80, 20);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(600, 25);
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // dgvDetalles
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(30, 160);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(700, 200);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(550, 380);
            this.lblTotal.Text = "Total: $0.00";

            // btnGuardar
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.Location = new System.Drawing.Point(30, 380);
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.Text = "Guardar Pedido";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FormPedidos
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.label1);
            this.Name = "FormPedidos";
            this.Text = "Gestión de Pedidos (Compras)";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}