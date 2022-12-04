
namespace PulperiaPY
{
    partial class FrmProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNameProv = new System.Windows.Forms.TextBox();
            this.txbTelProv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDirProv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProv = new System.Windows.Forms.Button();
            this.btnUpdProv = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnSearProv = new System.Windows.Forms.Button();
            this.txbSearProv = new System.Windows.Forms.TextBox();
            this.txbIdProv = new System.Windows.Forms.TextBox();
            this.btnCleProv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstProv = new System.Windows.Forms.ComboBox();
            this.btnDelProve = new System.Windows.Forms.Button();
            this.cmbFiltroProv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(41, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre proveedor:";
            // 
            // txbNameProv
            // 
            this.txbNameProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txbNameProv.Location = new System.Drawing.Point(45, 98);
            this.txbNameProv.Name = "txbNameProv";
            this.txbNameProv.Size = new System.Drawing.Size(163, 29);
            this.txbNameProv.TabIndex = 1;
            this.txbNameProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNameProv_KeyPress);
            // 
            // txbTelProv
            // 
            this.txbTelProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txbTelProv.Location = new System.Drawing.Point(238, 98);
            this.txbTelProv.Name = "txbTelProv";
            this.txbTelProv.Size = new System.Drawing.Size(136, 29);
            this.txbTelProv.TabIndex = 3;
            this.txbTelProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelProv_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(234, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono:";
            // 
            // txbDirProv
            // 
            this.txbDirProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txbDirProv.Location = new System.Drawing.Point(394, 98);
            this.txbDirProv.Multiline = true;
            this.txbDirProv.Name = "txbDirProv";
            this.txbDirProv.Size = new System.Drawing.Size(322, 144);
            this.txbDirProv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(390, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección";
            // 
            // btnAddProv
            // 
            this.btnAddProv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAddProv.FlatAppearance.BorderSize = 3;
            this.btnAddProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAddProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAddProv.Location = new System.Drawing.Point(91, 52);
            this.btnAddProv.Name = "btnAddProv";
            this.btnAddProv.Size = new System.Drawing.Size(130, 42);
            this.btnAddProv.TabIndex = 6;
            this.btnAddProv.Text = "Ingresar";
            this.btnAddProv.UseVisualStyleBackColor = true;
            this.btnAddProv.Click += new System.EventHandler(this.btnAddProv_Click);
            this.btnAddProv.MouseLeave += new System.EventHandler(this.btnAddProv_MouseLeave);
            this.btnAddProv.MouseHover += new System.EventHandler(this.btnAddProv_MouseHover);
            // 
            // btnUpdProv
            // 
            this.btnUpdProv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnUpdProv.FlatAppearance.BorderSize = 3;
            this.btnUpdProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnUpdProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnUpdProv.Location = new System.Drawing.Point(91, 115);
            this.btnUpdProv.Name = "btnUpdProv";
            this.btnUpdProv.Size = new System.Drawing.Size(130, 42);
            this.btnUpdProv.TabIndex = 7;
            this.btnUpdProv.Text = "Actualizar";
            this.btnUpdProv.UseVisualStyleBackColor = true;
            this.btnUpdProv.Click += new System.EventHandler(this.btnUpdProv_Click);
            this.btnUpdProv.MouseLeave += new System.EventHandler(this.btnUpdProv_MouseLeave);
            this.btnUpdProv.MouseHover += new System.EventHandler(this.btnUpdProv_MouseHover);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(33, 404);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(1034, 374);
            this.dgvProveedores.TabIndex = 10;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // btnSearProv
            // 
            this.btnSearProv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnSearProv.FlatAppearance.BorderSize = 3;
            this.btnSearProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnSearProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnSearProv.Location = new System.Drawing.Point(606, 343);
            this.btnSearProv.Name = "btnSearProv";
            this.btnSearProv.Size = new System.Drawing.Size(110, 35);
            this.btnSearProv.TabIndex = 11;
            this.btnSearProv.Text = "Buscar";
            this.btnSearProv.UseVisualStyleBackColor = true;
            this.btnSearProv.Click += new System.EventHandler(this.btnSearProv_Click);
            this.btnSearProv.MouseLeave += new System.EventHandler(this.btnSearProv_MouseLeave);
            this.btnSearProv.MouseHover += new System.EventHandler(this.btnSearProv_MouseHover);
            // 
            // txbSearProv
            // 
            this.txbSearProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txbSearProv.Location = new System.Drawing.Point(271, 346);
            this.txbSearProv.Name = "txbSearProv";
            this.txbSearProv.Size = new System.Drawing.Size(301, 29);
            this.txbSearProv.TabIndex = 12;
            this.txbSearProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearProv_KeyPress);
            // 
            // txbIdProv
            // 
            this.txbIdProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdProv.Location = new System.Drawing.Point(12, 12);
            this.txbIdProv.Name = "txbIdProv";
            this.txbIdProv.ReadOnly = true;
            this.txbIdProv.Size = new System.Drawing.Size(45, 22);
            this.txbIdProv.TabIndex = 14;
            this.txbIdProv.Visible = false;
            // 
            // btnCleProv
            // 
            this.btnCleProv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCleProv.FlatAppearance.BorderSize = 3;
            this.btnCleProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCleProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCleProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCleProv.Location = new System.Drawing.Point(253, 177);
            this.btnCleProv.Name = "btnCleProv";
            this.btnCleProv.Size = new System.Drawing.Size(110, 35);
            this.btnCleProv.TabIndex = 15;
            this.btnCleProv.Text = "Limpiar";
            this.btnCleProv.UseVisualStyleBackColor = true;
            this.btnCleProv.Click += new System.EventHandler(this.btnCleProv_Click);
            this.btnCleProv.MouseLeave += new System.EventHandler(this.btnCleProv_MouseLeave);
            this.btnCleProv.MouseHover += new System.EventHandler(this.btnCleProv_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(42, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estado:";
            // 
            // cmbEstProv
            // 
            this.cmbEstProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbEstProv.FormattingEnabled = true;
            this.cmbEstProv.Items.AddRange(new object[] {
            "Seleccione",
            "Activo",
            "Inactivo"});
            this.cmbEstProv.Location = new System.Drawing.Point(45, 181);
            this.cmbEstProv.Name = "cmbEstProv";
            this.cmbEstProv.Size = new System.Drawing.Size(120, 29);
            this.cmbEstProv.TabIndex = 17;
            this.cmbEstProv.SelectedIndexChanged += new System.EventHandler(this.cmbEstProv_SelectedIndexChanged);
            // 
            // btnDelProve
            // 
            this.btnDelProve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnDelProve.FlatAppearance.BorderSize = 3;
            this.btnDelProve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnDelProve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelProve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnDelProve.Location = new System.Drawing.Point(91, 178);
            this.btnDelProve.Name = "btnDelProve";
            this.btnDelProve.Size = new System.Drawing.Size(130, 42);
            this.btnDelProve.TabIndex = 19;
            this.btnDelProve.Text = "Eliminar";
            this.btnDelProve.UseVisualStyleBackColor = true;
            this.btnDelProve.Click += new System.EventHandler(this.btnDelProve_Click);
            this.btnDelProve.MouseLeave += new System.EventHandler(this.btnDelProve_MouseLeave);
            this.btnDelProve.MouseHover += new System.EventHandler(this.btnDelProve_MouseHover);
            // 
            // cmbFiltroProv
            // 
            this.cmbFiltroProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroProv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbFiltroProv.FormattingEnabled = true;
            this.cmbFiltroProv.Items.AddRange(new object[] {
            "Activos",
            "Inactivos",
            "Todos"});
            this.cmbFiltroProv.Location = new System.Drawing.Point(46, 347);
            this.cmbFiltroProv.Name = "cmbFiltroProv";
            this.cmbFiltroProv.Size = new System.Drawing.Size(120, 29);
            this.cmbFiltroProv.TabIndex = 20;
            this.cmbFiltroProv.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroProv_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(42, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mostrar proveedores:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProv);
            this.groupBox1.Controls.Add(this.btnUpdProv);
            this.groupBox1.Controls.Add(this.btnDelProve);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.groupBox1.Location = new System.Drawing.Point(756, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 273);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 821);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFiltroProv);
            this.Controls.Add(this.cmbEstProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCleProv);
            this.Controls.Add(this.txbIdProv);
            this.Controls.Add(this.txbSearProv);
            this.Controls.Add(this.btnSearProv);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.txbDirProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTelProv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNameProv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNameProv;
        private System.Windows.Forms.TextBox txbTelProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDirProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProv;
        private System.Windows.Forms.Button btnUpdProv;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnSearProv;
        private System.Windows.Forms.TextBox txbSearProv;
        private System.Windows.Forms.TextBox txbIdProv;
        private System.Windows.Forms.Button btnCleProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstProv;
        private System.Windows.Forms.Button btnDelProve;
        private System.Windows.Forms.ComboBox cmbFiltroProv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}