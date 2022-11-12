namespace PulperiaPY
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblTipoAccion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerVentas = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnEditarVenta = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.panelTotales = new System.Windows.Forms.GroupBox();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.gbInformacionVenta.SuspendLayout();
            this.gbInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTotalPagar.ForeColor = System.Drawing.Color.Lime;
            this.txtTotalPagar.Location = new System.Drawing.Point(37, 108);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(175, 34);
            this.txtTotalPagar.TabIndex = 0;
            this.txtTotalPagar.TabStop = false;
            this.txtTotalPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPagar_KeyPress);
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(37, 202);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(175, 34);
            this.txtPagaCon.TabIndex = 4;
            this.txtPagaCon.TextChanged += new System.EventHandler(this.txtPagaCon_TextChanged);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCambio.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCambio.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCambio.Location = new System.Drawing.Point(37, 300);
            this.txtCambio.Multiline = true;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(175, 34);
            this.txtCambio.TabIndex = 32;
            this.txtCambio.TabStop = false;
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.BackColor = System.Drawing.Color.White;
            this.btnFinalizarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnFinalizarVenta.FlatAppearance.BorderSize = 3;
            this.btnFinalizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnFinalizarVenta.Location = new System.Drawing.Point(37, 367);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(175, 75);
            this.btnFinalizarVenta.TabIndex = 5;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = false;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            this.btnFinalizarVenta.MouseLeave += new System.EventHandler(this.btnFinalizarVenta_MouseLeave);
            this.btnFinalizarVenta.MouseHover += new System.EventHandler(this.btnFinalizarVenta_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total a Pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paga con:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cambio:";
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.btnBuscarVenta);
            this.gbInformacionVenta.Controls.Add(this.txtNumVenta);
            this.gbInformacionVenta.Controls.Add(this.label11);
            this.gbInformacionVenta.Controls.Add(this.label4);
            this.gbInformacionVenta.Controls.Add(this.dtpFecha);
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbInformacionVenta.Location = new System.Drawing.Point(23, 53);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Size = new System.Drawing.Size(834, 166);
            this.gbInformacionVenta.TabIndex = 7;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Información venta";
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.BackColor = System.Drawing.Color.White;
            this.btnBuscarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnBuscarVenta.FlatAppearance.BorderSize = 2;
            this.btnBuscarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnBuscarVenta.Location = new System.Drawing.Point(212, 87);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(160, 45);
            this.btnBuscarVenta.TabIndex = 21;
            this.btnBuscarVenta.Text = "Buscar Venta";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            this.btnBuscarVenta.MouseLeave += new System.EventHandler(this.btnBuscarVenta_MouseLeave);
            this.btnBuscarVenta.MouseHover += new System.EventHandler(this.btnBuscarVenta_MouseHover);
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumVenta.Location = new System.Drawing.Point(22, 92);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.ReadOnly = true;
            this.txtNumVenta.Size = new System.Drawing.Size(167, 34);
            this.txtNumVenta.TabIndex = 23;
            this.txtNumVenta.TabStop = false;
            this.txtNumVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumVenta_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(20, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "Numero Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(568, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(573, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(224, 34);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.TabStop = false;
            this.dtpFecha.Value = new System.DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.Controls.Add(this.label9);
            this.gbInformacionProducto.Controls.Add(this.label8);
            this.gbInformacionProducto.Controls.Add(this.label7);
            this.gbInformacionProducto.Controls.Add(this.label6);
            this.gbInformacionProducto.Controls.Add(this.label5);
            this.gbInformacionProducto.Controls.Add(this.btnBuscar);
            this.gbInformacionProducto.Controls.Add(this.nudCantidad);
            this.gbInformacionProducto.Controls.Add(this.txtStock);
            this.gbInformacionProducto.Controls.Add(this.txtPrecio);
            this.gbInformacionProducto.Controls.Add(this.txtNombreProducto);
            this.gbInformacionProducto.Controls.Add(this.txtCodProducto);
            this.gbInformacionProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbInformacionProducto.Location = new System.Drawing.Point(23, 239);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Size = new System.Drawing.Size(1142, 166);
            this.gbInformacionProducto.TabIndex = 0;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Información del producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(957, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(812, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "En stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(727, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(386, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre del Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(20, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cod. Producto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnBuscar.Location = new System.Drawing.Point(273, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 45);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudCantidad.Location = new System.Drawing.Point(999, 92);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(123, 34);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtStock.Location = new System.Drawing.Point(862, 92);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(123, 34);
            this.txtStock.TabIndex = 14;
            this.txtStock.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(725, 92);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 34);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreProducto.Location = new System.Drawing.Point(389, 92);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(322, 34);
            this.txtNombreProducto.TabIndex = 12;
            this.txtNombreProducto.TabStop = false;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCodProducto.Location = new System.Drawing.Point(22, 92);
            this.txtCodProducto.MaxLength = 16;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(245, 34);
            this.txtCodProducto.TabIndex = 5;
            this.txtCodProducto.TabStop = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.White;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 3;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregarProducto.Location = new System.Drawing.Point(1220, 262);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(175, 121);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            this.btnAgregarProducto.MouseLeave += new System.EventHandler(this.btnAgregarProducto_MouseLeave);
            this.btnAgregarProducto.MouseHover += new System.EventHandler(this.btnAgregarProducto_MouseHover);
            // 
            // lblTipoAccion
            // 
            this.lblTipoAccion.AutoSize = true;
            this.lblTipoAccion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAccion.Location = new System.Drawing.Point(712, 9);
            this.lblTipoAccion.Name = "lblTipoAccion";
            this.lblTipoAccion.Size = new System.Drawing.Size(66, 41);
            this.lblTipoAccion.TabIndex = 11;
            this.lblTipoAccion.Text = "----";
            this.lblTipoAccion.Click += new System.EventHandler(this.lblTipoAccion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerVentas);
            this.groupBox1.Controls.Add(this.btnCancelarVenta);
            this.groupBox1.Controls.Add(this.btnEditarVenta);
            this.groupBox1.Controls.Add(this.btnNuevaVenta);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(885, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 166);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciónes";
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.BackColor = System.Drawing.Color.White;
            this.btnVerVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnVerVentas.FlatAppearance.BorderSize = 3;
            this.btnVerVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnVerVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnVerVentas.Location = new System.Drawing.Point(406, 55);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Size = new System.Drawing.Size(117, 77);
            this.btnVerVentas.TabIndex = 36;
            this.btnVerVentas.TabStop = false;
            this.btnVerVentas.Text = "Ver Ventas";
            this.btnVerVentas.UseVisualStyleBackColor = false;
            this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
            this.btnVerVentas.MouseLeave += new System.EventHandler(this.btnVerVentas_MouseLeave);
            this.btnVerVentas.MouseHover += new System.EventHandler(this.btnVerVentas_MouseHover);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.White;
            this.btnCancelarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelarVenta.FlatAppearance.BorderSize = 3;
            this.btnCancelarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelarVenta.Location = new System.Drawing.Point(154, 55);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(117, 77);
            this.btnCancelarVenta.TabIndex = 35;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseCompatibleTextRendering = true;
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            this.btnCancelarVenta.MouseLeave += new System.EventHandler(this.btnCancelarVenta_MouseLeave);
            this.btnCancelarVenta.MouseHover += new System.EventHandler(this.btnCancelarVenta_MouseHover);
            // 
            // btnEditarVenta
            // 
            this.btnEditarVenta.BackColor = System.Drawing.Color.White;
            this.btnEditarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnEditarVenta.FlatAppearance.BorderSize = 3;
            this.btnEditarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnEditarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnEditarVenta.Location = new System.Drawing.Point(280, 55);
            this.btnEditarVenta.Name = "btnEditarVenta";
            this.btnEditarVenta.Size = new System.Drawing.Size(117, 77);
            this.btnEditarVenta.TabIndex = 34;
            this.btnEditarVenta.Text = "Editar Venta";
            this.btnEditarVenta.UseVisualStyleBackColor = false;
            this.btnEditarVenta.Click += new System.EventHandler(this.btnEditarVenta_Click);
            this.btnEditarVenta.MouseLeave += new System.EventHandler(this.btnEditarVenta_MouseLeave);
            this.btnEditarVenta.MouseHover += new System.EventHandler(this.btnEditarVenta_MouseHover);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.White;
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNuevaVenta.FlatAppearance.BorderSize = 3;
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNuevaVenta.Location = new System.Drawing.Point(28, 55);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(117, 77);
            this.btnNuevaVenta.TabIndex = 33;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            this.btnNuevaVenta.MouseLeave += new System.EventHandler(this.btnNuevaVenta_MouseLeave);
            this.btnNuevaVenta.MouseHover += new System.EventHandler(this.btnNuevaVenta_MouseHover);
            // 
            // panelTotales
            // 
            this.panelTotales.Controls.Add(this.label1);
            this.panelTotales.Controls.Add(this.btnFinalizarVenta);
            this.panelTotales.Controls.Add(this.txtTotalPagar);
            this.panelTotales.Controls.Add(this.label3);
            this.panelTotales.Controls.Add(this.txtPagaCon);
            this.panelTotales.Controls.Add(this.label2);
            this.panelTotales.Controls.Add(this.txtCambio);
            this.panelTotales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panelTotales.Location = new System.Drawing.Point(1183, 425);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(250, 486);
            this.panelTotales.TabIndex = 35;
            this.panelTotales.TabStop = false;
            this.panelTotales.Text = "Detalle Venta";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(23, 425);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(1142, 486);
            this.dgvDetalleVenta.TabIndex = 36;
            this.dgvDetalleVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellClick);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1471, 1011);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.panelTotales);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTipoAccion);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.gbInformacionProducto);
            this.Controls.Add(this.gbInformacionVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.gbInformacionProducto.ResumeLayout(false);
            this.gbInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelTotales.ResumeLayout(false);
            this.panelTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gbInformacionProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipoAccion;
        private System.Windows.Forms.TextBox txtNumVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarVenta;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnVerVentas;
        private System.Windows.Forms.GroupBox panelTotales;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
    }
}