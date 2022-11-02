using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace PulperiaPY
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Ingrese ID", "Editar Usuario");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Ingrese ID", "Eliminar Usuario");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
