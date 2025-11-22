namespace AlmacenPF
{
    partial class FormVentas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();

            // lblCliente
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(30, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Text = "Seleccionar Cliente:";

            // cmbClientes
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(140, 22);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(250, 21);
            this.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(450, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha:";

            // dtpFecha
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(500, 22);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.Enabled = false;

            // grpProducto
            this.grpProducto.Controls.Add(this.lblStock);
            this.grpProducto.Controls.Add(this.btnAgregar);
            this.grpProducto.Controls.Add(this.txtCantidad);
            this.grpProducto.Controls.Add(this.lblCantidad);
            this.grpProducto.Controls.Add(this.cmbArticulos);
            this.grpProducto.Controls.Add(this.lblArticulo);
            this.grpProducto.Location = new System.Drawing.Point(30, 70);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(700, 80);
            this.grpProducto.Text = "Datos del Producto";

            // lblArticulo
            this.lblArticulo.AutoSize = true; this.lblArticulo.Location = new System.Drawing.Point(20, 30); this.lblArticulo.Text = "Artículo:";
            // cmbArticulos
            this.cmbArticulos.FormattingEnabled = true; this.cmbArticulos.Location = new System.Drawing.Point(80, 27); this.cmbArticulos.Name = "cmbArticulos"; this.cmbArticulos.Size = new System.Drawing.Size(280, 21);
            // lblCantidad
            this.lblCantidad.AutoSize = true; this.lblCantidad.Location = new System.Drawing.Point(380, 30); this.lblCantidad.Text = "Cantidad:";
            // txtCantidad
            this.txtCantidad.Location = new System.Drawing.Point(440, 27); this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(550, 25); this.btnAgregar.Name = "btnAgregar"; this.btnAgregar.Size = new System.Drawing.Size(100, 25); this.btnAgregar.Text = "Agregar"; this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // lblStock
            this.lblStock.AutoSize = true; this.lblStock.ForeColor = System.Drawing.Color.Blue; this.lblStock.Location = new System.Drawing.Point(80, 55); this.lblStock.Name = "lblStock"; this.lblStock.Text = "Stock Disponible: --";

            // dgvCarrito
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(30, 170);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(700, 200);
            this.dgvCarrito.AllowUserToAddRows = false;

            // lblTotalPagar
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalPagar.Location = new System.Drawing.Point(500, 390);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Text = "TOTAL: $0.00";

            // btnFacturar
            this.btnFacturar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.Location = new System.Drawing.Point(30, 390);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(200, 50);
            this.btnFacturar.Text = "FINALIZAR VENTA";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFinalizarVenta_Click);

            // FormVentas
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbClientes); // AGREGADO
            this.Controls.Add(this.lblCliente);
            this.Name = "FormVentas";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}