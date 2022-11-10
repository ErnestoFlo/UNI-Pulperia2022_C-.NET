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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.PanelDetalleVenta = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.PanelVentas = new System.Windows.Forms.Panel();
            this.gbInformacionVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.gbReporte.SuspendLayout();
            this.PanelDetalleVenta.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.PanelDetalleVenta.Location = new System.Drawing.Point(12, 9);
            this.PanelDetalleVenta.Name = "PanelDetalleVenta";
            this.PanelDetalleVenta.Size = new System.Drawing.Size(1078, 622);
            this.PanelDetalleVenta.TabIndex = 11;
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
            // PanelVentas
            // 
            this.PanelVentas.Location = new System.Drawing.Point(12, 9);
            this.PanelVentas.Name = "PanelVentas";
            this.PanelVentas.Size = new System.Drawing.Size(1078, 622);
            this.PanelVentas.TabIndex = 11;
            // 
            // VerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 643);
            this.Controls.Add(this.PanelVentas);
            this.Controls.Add(this.PanelDetalleVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VerVentas";
            this.Text = "VerVentas";
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.gbReporte.ResumeLayout(false);
            this.PanelDetalleVenta.ResumeLayout(false);
            this.PanelDetalleVenta.PerformLayout();
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
    }
}