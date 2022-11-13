using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PulperiaPY
{
    public partial class FCompra : Form
    {
        public FCompra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();
        }
    }
}
