
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
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre proveedor:";
            // 
            // txbNameProv
            // 
            this.txbNameProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameProv.Location = new System.Drawing.Point(31, 45);
            this.txbNameProv.Name = "txbNameProv";
            this.txbNameProv.Size = new System.Drawing.Size(163, 22);
            this.txbNameProv.TabIndex = 1;
            // 
            // txbTelProv
            // 
            this.txbTelProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelProv.Location = new System.Drawing.Point(224, 45);
            this.txbTelProv.Name = "txbTelProv";
            this.txbTelProv.Size = new System.Drawing.Size(100, 22);
            this.txbTelProv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono:";
            // 
            // txbDirProv
            // 
            this.txbDirProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDirProv.Location = new System.Drawing.Point(356, 45);
            this.txbDirProv.Multiline = true;
            this.txbDirProv.Name = "txbDirProv";
            this.txbDirProv.Size = new System.Drawing.Size(221, 91);
            this.txbDirProv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección";
            // 
            // btnAddProv
            // 
            this.btnAddProv.Location = new System.Drawing.Point(602, 12);
            this.btnAddProv.Name = "btnAddProv";
            this.btnAddProv.Size = new System.Drawing.Size(110, 34);
            this.btnAddProv.TabIndex = 6;
            this.btnAddProv.Text = "Ingresar";
            this.btnAddProv.UseVisualStyleBackColor = true;
            this.btnAddProv.Click += new System.EventHandler(this.btnAddProv_Click);
            // 
            // btnUpdProv
            // 
            this.btnUpdProv.Location = new System.Drawing.Point(602, 52);
            this.btnUpdProv.Name = "btnUpdProv";
            this.btnUpdProv.Size = new System.Drawing.Size(110, 34);
            this.btnUpdProv.TabIndex = 7;
            this.btnUpdProv.Text = "Actualizar";
            this.btnUpdProv.UseVisualStyleBackColor = true;
            this.btnUpdProv.Click += new System.EventHandler(this.btnUpdProv_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reporte";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(31, 194);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(681, 233);
            this.dgvProveedores.TabIndex = 10;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // btnSearProv
            // 
            this.btnSearProv.Location = new System.Drawing.Point(379, 159);
            this.btnSearProv.Name = "btnSearProv";
            this.btnSearProv.Size = new System.Drawing.Size(75, 23);
            this.btnSearProv.TabIndex = 11;
            this.btnSearProv.Text = "Buscar";
            this.btnSearProv.UseVisualStyleBackColor = true;
            this.btnSearProv.Click += new System.EventHandler(this.btnSearProv_Click);
            // 
            // txbSearProv
            // 
            this.txbSearProv.Location = new System.Drawing.Point(185, 161);
            this.txbSearProv.Name = "txbSearProv";
            this.txbSearProv.Size = new System.Drawing.Size(188, 20);
            this.txbSearProv.TabIndex = 12;
            this.txbSearProv.TextChanged += new System.EventHandler(this.txbSearProv_TextChanged);
            // 
            // txbIdProv
            // 
            this.txbIdProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdProv.Location = new System.Drawing.Point(3, 1);
            this.txbIdProv.Name = "txbIdProv";
            this.txbIdProv.ReadOnly = true;
            this.txbIdProv.Size = new System.Drawing.Size(45, 22);
            this.txbIdProv.TabIndex = 14;
            this.txbIdProv.Visible = false;
            // 
            // btnCleProv
            // 
            this.btnCleProv.Location = new System.Drawing.Point(485, 147);
            this.btnCleProv.Name = "btnCleProv";
            this.btnCleProv.Size = new System.Drawing.Size(92, 34);
            this.btnCleProv.TabIndex = 15;
            this.btnCleProv.Text = "Limpiar";
            this.btnCleProv.UseVisualStyleBackColor = true;
            this.btnCleProv.Click += new System.EventHandler(this.btnCleProv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estado:";
            // 
            // cmbEstProv
            // 
            this.cmbEstProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstProv.FormattingEnabled = true;
            this.cmbEstProv.Items.AddRange(new object[] {
            "Seleccione",
            "Activo",
            "Inactivo"});
            this.cmbEstProv.Location = new System.Drawing.Point(31, 105);
            this.cmbEstProv.Name = "cmbEstProv";
            this.cmbEstProv.Size = new System.Drawing.Size(101, 21);
            this.cmbEstProv.TabIndex = 17;
            this.cmbEstProv.SelectedIndexChanged += new System.EventHandler(this.cmbEstProv_SelectedIndexChanged);
            // 
            // btnDelProve
            // 
            this.btnDelProve.Location = new System.Drawing.Point(602, 97);
            this.btnDelProve.Name = "btnDelProve";
            this.btnDelProve.Size = new System.Drawing.Size(110, 34);
            this.btnDelProve.TabIndex = 19;
            this.btnDelProve.Text = "Eliminar";
            this.btnDelProve.UseVisualStyleBackColor = true;
            this.btnDelProve.Click += new System.EventHandler(this.btnDelProve_Click);
            // 
            // cmbFiltroProv
            // 
            this.cmbFiltroProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroProv.FormattingEnabled = true;
            this.cmbFiltroProv.Items.AddRange(new object[] {
            "Activos",
            "Inactivos",
            "Todos"});
            this.cmbFiltroProv.Location = new System.Drawing.Point(31, 161);
            this.cmbFiltroProv.Name = "cmbFiltroProv";
            this.cmbFiltroProv.Size = new System.Drawing.Size(101, 21);
            this.cmbFiltroProv.TabIndex = 20;
            this.cmbFiltroProv.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroProv_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mostrar proveedores:";
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFiltroProv);
            this.Controls.Add(this.btnDelProve);
            this.Controls.Add(this.cmbEstProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCleProv);
            this.Controls.Add(this.txbIdProv);
            this.Controls.Add(this.txbSearProv);
            this.Controls.Add(this.btnSearProv);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdProv);
            this.Controls.Add(this.btnAddProv);
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
        private System.Windows.Forms.Button button3;
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
    }
}