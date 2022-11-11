namespace PulperiaPY
{
    partial class VerVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelDetalleVenta = new System.Windows.Forms.Panel();
            this.PanelVentas = new System.Windows.Forms.Panel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.cmbFiltroBusqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstadoVenta = new System.Windows.Forms.ComboBox();
            this.dtpGetDate = new System.Windows.Forms.DateTimePicker();
            this.gbInformacionVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.gbReporte.SuspendLayout();
            this.PanelDetalleVenta.SuspendLayout();
            this.PanelVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.txtTotalPagar);
            this.gbInformacionVenta.Controls.Add(this.label1);
            this.gbInformacionVenta.Controls.Add(this.txtNumVenta);
            this.gbInformacionVenta.Controls.Add(this.label11);
            this.gbInformacionVenta.Controls.Add(this.label4);
            this.gbInformacionVenta.Controls.Add(this.dtpFecha);
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.Location = new System.Drawing.Point(18, 48);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Size = new System.Drawing.Size(684, 117);
            this.gbInformacionVenta.TabIndex = 8;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Información venta";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(465, 66);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(167, 30);
            this.txtTotalPagar.TabIndex = 25;
            this.txtTotalPagar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total Venta";
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.Location = new System.Drawing.Point(49, 66);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.ReadOnly = true;
            this.txtNumVenta.Size = new System.Drawing.Size(167, 30);
            this.txtNumVenta.TabIndex = 23;
            this.txtNumVenta.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Numero Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(257, 66);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(167, 30);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.TabStop = false;
            this.dtpFecha.Value = new System.DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDetalleVenta);
            this.panel1.Location = new System.Drawing.Point(18, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 413);
            this.panel1.TabIndex = 9;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(1042, 413);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.btnRegresar);
            this.gbReporte.Controls.Add(this.btnReporte);
            this.gbReporte.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReporte.Location = new System.Drawing.Point(718, 48);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(342, 117);
            this.gbReporte.TabIndex = 10;
            this.gbReporte.TabStop = false;
            this.gbReporte.Text = "Acción Reporte";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(186, 37);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(123, 59);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseCompatibleTextRendering = true;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(31, 37);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(123, 59);
            this.btnReporte.TabIndex = 36;
            this.btnReporte.Text = "Ver Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(456, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venta";
            // 
            // PanelDetalleVenta
            // 
            this.PanelDetalleVenta.Controls.Add(this.gbInformacionVenta);
            this.PanelDetalleVenta.Controls.Add(this.label2);
            this.PanelDetalleVenta.Controls.Add(this.panel1);
            this.PanelDetalleVenta.Controls.Add(this.gbReporte);
            this.PanelDetalleVenta.Enabled = false;
            this.PanelDetalleVenta.Location = new System.Drawing.Point(9, 9);
            this.PanelDetalleVenta.Name = "PanelDetalleVenta";
            this.PanelDetalleVenta.Size = new System.Drawing.Size(1090, 616);
            this.PanelDetalleVenta.TabIndex = 11;
            this.PanelDetalleVenta.Visible = false;
            // 
            // PanelVentas
            // 
            this.PanelVentas.Controls.Add(this.dgvVentas);
            this.PanelVentas.Controls.Add(this.groupBox1);
            this.PanelVentas.Controls.Add(this.label5);
            this.PanelVentas.Location = new System.Drawing.Point(24, 9);
            this.PanelVentas.Name = "PanelVentas";
            this.PanelVentas.Size = new System.Drawing.Size(1078, 619);
            this.PanelVentas.TabIndex = 11;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(21, 186);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(1036, 422);
            this.dgvVentas.TabIndex = 6;
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpGetDate);
            this.groupBox1.Controls.Add(this.btnVerTodo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbFiltroBusqueda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEstadoVenta);
            this.groupBox1.Controls.Add(this.txtCodigoBusqueda);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Ventas";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Location = new System.Drawing.Point(842, 47);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(125, 35);
            this.btnVerTodo.TabIndex = 9;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(713, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(412, 48);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(267, 30);
            this.txtCodigoBusqueda.TabIndex = 6;
            // 
            // cmbFiltroBusqueda
            // 
            this.cmbFiltroBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroBusqueda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroBusqueda.FormattingEnabled = true;
            this.cmbFiltroBusqueda.Items.AddRange(new object[] {
            "Numero de Venta",
            "Fecha de Venta",
            "Estado de Venta"});
            this.cmbFiltroBusqueda.Location = new System.Drawing.Point(171, 48);
            this.cmbFiltroBusqueda.Name = "cmbFiltroBusqueda";
            this.cmbFiltroBusqueda.Size = new System.Drawing.Size(224, 31);
            this.cmbFiltroBusqueda.TabIndex = 4;
            this.cmbFiltroBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroBusqueda_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.2F);
            this.label3.Location = new System.Drawing.Point(62, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar por";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lista de Ventas";
            // 
            // cmbEstadoVenta
            // 
            this.cmbEstadoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoVenta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoVenta.FormattingEnabled = true;
            this.cmbEstadoVenta.Items.AddRange(new object[] {
            "Cancelada",
            "Finalizada",
            "Editada"});
            this.cmbEstadoVenta.Location = new System.Drawing.Point(412, 47);
            this.cmbEstadoVenta.Name = "cmbEstadoVenta";
            this.cmbEstadoVenta.Size = new System.Drawing.Size(267, 31);
            this.cmbEstadoVenta.TabIndex = 10;
            // 
            // dtpGetDate
            // 
            this.dtpGetDate.CustomFormat = "";
            this.dtpGetDate.Enabled = false;
            this.dtpGetDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGetDate.Location = new System.Drawing.Point(452, 47);
            this.dtpGetDate.Name = "dtpGetDate";
            this.dtpGetDate.Size = new System.Drawing.Size(167, 30);
            this.dtpGetDate.TabIndex = 11;
            this.dtpGetDate.TabStop = false;
            this.dtpGetDate.Value = new System.DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // VerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 643);
            this.Controls.Add(this.PanelDetalleVenta);
            this.Controls.Add(this.PanelVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VerVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerVentas";
            this.Load += new System.EventHandler(this.VerVentas_Load);
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.gbReporte.ResumeLayout(false);
            this.PanelDetalleVenta.ResumeLayout(false);
            this.PanelDetalleVenta.PerformLayout();
            this.PanelVentas.ResumeLayout(false);
            this.PanelVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelDetalleVenta;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel PanelVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.ComboBox cmbFiltroBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstadoVenta;
        private System.Windows.Forms.DateTimePicker dtpGetDate;
    }
}