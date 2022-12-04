namespace PulperiaPY
{
    partial class Producto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriacb = new System.Windows.Forms.ComboBox();
            this.marcacb = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNC = new System.Windows.Forms.Button();
            this.btnNM = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregaNuevo = new System.Windows.Forms.Button();
            this.btnCancelarNuevo = new System.Windows.Forms.Button();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbInformacionVenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código de Producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Sugerido";
            // 
            // categoriacb
            // 
            this.categoriacb.FormattingEnabled = true;
            this.categoriacb.Location = new System.Drawing.Point(263, 86);
            this.categoriacb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoriacb.Name = "categoriacb";
            this.categoriacb.Size = new System.Drawing.Size(209, 36);
            this.categoriacb.TabIndex = 5;
            // 
            // marcacb
            // 
            this.marcacb.FormattingEnabled = true;
            this.marcacb.Location = new System.Drawing.Point(263, 35);
            this.marcacb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marcacb.Name = "marcacb";
            this.marcacb.Size = new System.Drawing.Size(209, 36);
            this.marcacb.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(263, 144);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(209, 34);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(262, 197);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 34);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(263, 250);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(209, 34);
            this.txtPrecio.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregar.Location = new System.Drawing.Point(16, 49);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 76);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnLimpiar.Location = new System.Drawing.Point(315, 49);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 76);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.MouseLeave += new System.EventHandler(this.btnLimpiar_MouseLeave);
            this.btnLimpiar.MouseHover += new System.EventHandler(this.btnLimpiar_MouseHover);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelar.Location = new System.Drawing.Point(167, 49);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 76);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnNC
            // 
            this.btnNC.BackColor = System.Drawing.Color.White;
            this.btnNC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNC.FlatAppearance.BorderSize = 2;
            this.btnNC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNC.Location = new System.Drawing.Point(193, 35);
            this.btnNC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNC.Name = "btnNC";
            this.btnNC.Size = new System.Drawing.Size(139, 90);
            this.btnNC.TabIndex = 13;
            this.btnNC.Text = "Nueva Categoria";
            this.btnNC.UseVisualStyleBackColor = false;
            this.btnNC.Click += new System.EventHandler(this.button1_Click_1);
            this.btnNC.MouseLeave += new System.EventHandler(this.btnNC_MouseLeave);
            this.btnNC.MouseHover += new System.EventHandler(this.btnNC_MouseHover);
            // 
            // btnNM
            // 
            this.btnNM.BackColor = System.Drawing.Color.White;
            this.btnNM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNM.FlatAppearance.BorderSize = 2;
            this.btnNM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnNM.Location = new System.Drawing.Point(24, 35);
            this.btnNM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNM.Name = "btnNM";
            this.btnNM.Size = new System.Drawing.Size(145, 90);
            this.btnNM.TabIndex = 14;
            this.btnNM.Text = "Nueva Marca";
            this.btnNM.UseVisualStyleBackColor = false;
            this.btnNM.Click += new System.EventHandler(this.button2_Click);
            this.btnNM.MouseLeave += new System.EventHandler(this.btnNM_MouseLeave);
            this.btnNM.MouseHover += new System.EventHandler(this.btnNM_MouseHover);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(910, 188);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(200, 28);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Nombre marca nueva";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(913, 229);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(188, 34);
            this.txtMarca.TabIndex = 16;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(891, 188);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(229, 28);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Nombre categoria nueva";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(915, 238);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(188, 34);
            this.txtCategoria.TabIndex = 18;
            // 
            // btnAgregaNuevo
            // 
            this.btnAgregaNuevo.BackColor = System.Drawing.Color.White;
            this.btnAgregaNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregaNuevo.FlatAppearance.BorderSize = 2;
            this.btnAgregaNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregaNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregaNuevo.Location = new System.Drawing.Point(941, 289);
            this.btnAgregaNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregaNuevo.Name = "btnAgregaNuevo";
            this.btnAgregaNuevo.Size = new System.Drawing.Size(122, 54);
            this.btnAgregaNuevo.TabIndex = 19;
            this.btnAgregaNuevo.Text = "Agregar";
            this.btnAgregaNuevo.UseVisualStyleBackColor = false;
            this.btnAgregaNuevo.Click += new System.EventHandler(this.btnAgregaNuevo_Click);
            this.btnAgregaNuevo.MouseLeave += new System.EventHandler(this.btnAgregaNuevo_MouseLeave);
            this.btnAgregaNuevo.MouseHover += new System.EventHandler(this.btnAgregaNuevo_MouseHover);
            // 
            // btnCancelarNuevo
            // 
            this.btnCancelarNuevo.BackColor = System.Drawing.Color.White;
            this.btnCancelarNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelarNuevo.FlatAppearance.BorderSize = 2;
            this.btnCancelarNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnCancelarNuevo.Location = new System.Drawing.Point(941, 361);
            this.btnCancelarNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarNuevo.Name = "btnCancelarNuevo";
            this.btnCancelarNuevo.Size = new System.Drawing.Size(122, 54);
            this.btnCancelarNuevo.TabIndex = 20;
            this.btnCancelarNuevo.Text = "Cancelar";
            this.btnCancelarNuevo.UseVisualStyleBackColor = false;
            this.btnCancelarNuevo.Click += new System.EventHandler(this.button3_Click);
            this.btnCancelarNuevo.MouseLeave += new System.EventHandler(this.btnCancelarNuevo_MouseLeave);
            this.btnCancelarNuevo.MouseHover += new System.EventHandler(this.btnCancelarNuevo_MouseHover);
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.categoriacb);
            this.gbInformacionVenta.Controls.Add(this.label1);
            this.gbInformacionVenta.Controls.Add(this.label2);
            this.gbInformacionVenta.Controls.Add(this.label3);
            this.gbInformacionVenta.Controls.Add(this.label4);
            this.gbInformacionVenta.Controls.Add(this.label5);
            this.gbInformacionVenta.Controls.Add(this.marcacb);
            this.gbInformacionVenta.Controls.Add(this.txtCodigo);
            this.gbInformacionVenta.Controls.Add(this.txtNombre);
            this.gbInformacionVenta.Controls.Add(this.txtPrecio);
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbInformacionVenta.Location = new System.Drawing.Point(12, 13);
            this.gbInformacionVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformacionVenta.Size = new System.Drawing.Size(490, 308);
            this.gbInformacionVenta.TabIndex = 21;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Información Producto";
            this.gbInformacionVenta.Enter += new System.EventHandler(this.gbInformacionVenta_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(508, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(475, 154);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNM);
            this.groupBox2.Controls.Add(this.btnNC);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(508, 175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(350, 146);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones Extra";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 728);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInformacionVenta);
            this.Controls.Add(this.btnCancelarNuevo);
            this.Controls.Add(this.btnAgregaNuevo);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoriacb;
        private System.Windows.Forms.ComboBox marcacb;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNC;
        private System.Windows.Forms.Button btnNM;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnAgregaNuevo;
        private System.Windows.Forms.Button btnCancelarNuevo;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}