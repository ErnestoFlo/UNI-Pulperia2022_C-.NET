namespace PulperiaPY
{
    partial class FrmDetalleCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarDetalle = new System.Windows.Forms.TextBox();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.txtUltimoIdDetalleCompra = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtUltimoIdCompra = new System.Windows.Forms.TextBox();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Compra";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(103, 26);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(86, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(103, 57);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(86, 20);
            this.txtPrecioCompra.TabIndex = 3;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnConfirmarCompra);
            this.gbAcciones.Controls.Add(this.btnLimpiar);
            this.gbAcciones.Controls.Add(this.btnEliminar);
            this.gbAcciones.Controls.Add(this.btnModificar);
            this.gbAcciones.Controls.Add(this.btnIngresar);
            this.gbAcciones.Location = new System.Drawing.Point(338, 22);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(361, 97);
            this.gbAcciones.TabIndex = 4;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(221, 31);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 44);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(153, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 44);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(85, 31);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 44);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseUp);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(17, 31);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(62, 44);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIngresar_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbBuscar);
            this.groupBox2.Controls.Add(this.txtBuscarProducto);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Location = new System.Drawing.Point(20, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 166);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Producto";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(210, 19);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(444, 132);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // label3
            // 
            this.label3.AccessibleName = "lbFecha";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto:";
            // 
            // lbBuscar
            // 
            this.lbBuscar.AccessibleName = "lbFecha";
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(15, 113);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(43, 13);
            this.lbBuscar.TabIndex = 4;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(76, 110);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(90, 20);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(76, 53);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(90, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDetalleCompra);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBuscarDetalle);
            this.groupBox3.Location = new System.Drawing.Point(20, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 146);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Detalle de Compras";
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(192, 24);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.Size = new System.Drawing.Size(462, 103);
            this.dgvDetalleCompra.TabIndex = 8;
            this.dgvDetalleCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCompra_CellClick);
            // 
            // label4
            // 
            this.label4.AccessibleName = "lbFecha";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar:";
            // 
            // txtBuscarDetalle
            // 
            this.txtBuscarDetalle.Location = new System.Drawing.Point(64, 39);
            this.txtBuscarDetalle.Name = "txtBuscarDetalle";
            this.txtBuscarDetalle.Size = new System.Drawing.Size(101, 20);
            this.txtBuscarDetalle.TabIndex = 0;
            this.txtBuscarDetalle.TextChanged += new System.EventHandler(this.txtBuscarDetalle_TextChanged);
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Enabled = false;
            this.txtIdDetalle.Location = new System.Drawing.Point(762, 194);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(43, 20);
            this.txtIdDetalle.TabIndex = 7;
            this.txtIdDetalle.Visible = false;
            // 
            // txtUltimoIdDetalleCompra
            // 
            this.txtUltimoIdDetalleCompra.Enabled = false;
            this.txtUltimoIdDetalleCompra.Location = new System.Drawing.Point(762, 220);
            this.txtUltimoIdDetalleCompra.Name = "txtUltimoIdDetalleCompra";
            this.txtUltimoIdDetalleCompra.Size = new System.Drawing.Size(43, 20);
            this.txtUltimoIdDetalleCompra.TabIndex = 8;
            this.txtUltimoIdDetalleCompra.Visible = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(762, 272);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(43, 20);
            this.txtIdProducto.TabIndex = 9;
            this.txtIdProducto.Visible = false;
            // 
            // txtUltimoIdCompra
            // 
            this.txtUltimoIdCompra.Enabled = false;
            this.txtUltimoIdCompra.Location = new System.Drawing.Point(762, 246);
            this.txtUltimoIdCompra.Name = "txtUltimoIdCompra";
            this.txtUltimoIdCompra.Size = new System.Drawing.Size(43, 20);
            this.txtUltimoIdCompra.TabIndex = 10;
            this.txtUltimoIdCompra.Visible = false;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(289, 31);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(62, 44);
            this.btnConfirmarCompra.TabIndex = 4;
            this.btnConfirmarCompra.Text = "Confirmar Compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // FrmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 485);
            this.Controls.Add(this.txtUltimoIdCompra);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtUltimoIdDetalleCompra);
            this.Controls.Add(this.txtIdDetalle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDetalleCompra";
            this.Text = "FrmDetalleCompra";
            this.Load += new System.EventHandler(this.FrmDetalleCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarDetalle;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.TextBox txtUltimoIdDetalleCompra;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtUltimoIdCompra;
        private System.Windows.Forms.Button btnConfirmarCompra;
    }
}