using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PulperiaPY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("exec spLogin @user, @pass", conexion.Conectar);
            cmd.Parameters.AddWithValue("@user", txtuser.Text);
            cmd.Parameters.AddWithValue("@pass", txtpass.Text);
            try
            {

                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    ListadoUsuarios ListadoUsuarios = new ListadoUsuarios();
                    ListadoUsuarios.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Aviso");
                    
                }
                conexion.CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Close();

        }
    }
}
