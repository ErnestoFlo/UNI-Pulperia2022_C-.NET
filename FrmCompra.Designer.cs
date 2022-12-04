namespace PulperiaPY
{
    partial class FrmCompra
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarCompra = new System.Windows.Forms.TextBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtBuscarCompra);
            this.groupBox4.Controls.Add(this.dgvCompra);
            this.groupBox4.Location = new System.Drawing.Point(12, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1181, 262);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de compras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Buscar";
            // 
            // txtBuscarCompra
            // 
            this.txtBuscarCompra.Location = new System.Drawing.Point(11, 57);
            this.txtBuscarCompra.Name = "txtBuscarCompra";
            this.txtBuscarCompra.Size = new System.Drawing.Size(228, 26);
            this.txtBuscarCompra.TabIndex = 25;
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(255, 37);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersWidth = 62;
            this.dgvCompra.RowTemplate.Height = 28;
            this.dgvCompra.Size = new System.Drawing.Size(900, 210);
            this.dgvCompra.TabIndex = 24;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellClick_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIngresar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnReporte);
            this.groupBox3.Location = new System.Drawing.Point(560, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 100);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnIngresar.FlatAppearance.BorderSize = 3;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnIngresar.Location = new System.Drawing.Point(17, 29);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(127, 53);
            this.btnIngresar.TabIndex = 13;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(110, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 53);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(203, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 53);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(296, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 53);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(389, 31);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(102, 53);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Detalle de Compra";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBuscarProveedor);
            this.groupBox2.Controls.Add(this.txtNombreProveedor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvProveedores);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 241);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Buscar";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(13, 123);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(228, 26);
            this.txtBuscarProveedor.TabIndex = 27;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(11, 61);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(228, 26);
            this.txtNombreProveedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(251, 25);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 62;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.Size = new System.Drawing.Size(904, 201);
            this.dgvProveedores.TabIndex = 2;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFechaAdquisicion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 112);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de compra";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Items.AddRange(new object[] {
            "Aprobado",
            "Cancelado",
            "Cerrado",
            "En suspenso",
            "En progreso",
            "Revisión pendiente",
            "Revisado",
            "En espera"});
            this.cmbEstado.Location = new System.Drawing.Point(255, 54);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(228, 28);
            this.cmbEstado.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha ";
            // 
            // dtpFechaAdquisicion
            // 
            this.dtpFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAdquisicion.Location = new System.Drawing.Point(17, 54);
            this.dtpFechaAdquisicion.MinDate = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            this.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            this.dtpFechaAdquisicion.Size = new System.Drawing.Size(228, 26);
            this.dtpFechaAdquisicion.TabIndex = 6;
            this.dtpFechaAdquisicion.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Estado";
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(157, 25);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.ReadOnly = true;
            this.txtIdCompra.Size = new System.Drawing.Size(100, 26);
            this.txtIdCompra.TabIndex = 32;
            this.txtIdCompra.Visible = false;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(29, 25);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 26);
            this.txtIdProveedor.TabIndex = 31;
            this.txtIdProveedor.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "#Id factura = id compra";
            this.label2.Visible = false;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 774);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdCompra);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarCompra;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label2;
    }
}