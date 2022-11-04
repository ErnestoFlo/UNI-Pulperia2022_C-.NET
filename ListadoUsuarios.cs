using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PulperiaPY
{
    public partial class ListadoUsuarios : Form
    {
        public int idUser;
        public string usuario;
        public string contraseña;
        public string nombre;
        public string apellido;
        public string correo;
        public string telefono;
        public ListadoUsuarios()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("exec VerUsuarios", conexion.Conectar);
            adapter.SelectCommand = cmd;
            var datoscbox = new[] { "idUsuario", "username", "nombre", "apellido", "correo", "telefono" };
            try
            {
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                dgvUsers.DataSource = table;
                cboxfilter.DataSource = datoscbox;
                cboxfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                conexion.CerrarConexion();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al traer los datos" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            string filtro = cboxfilter.Text;
            if(filtro == "idUsuario")
            {
                SqlCommand cmd = new SqlCommand("Select idUsuario, username,nombre, apellido, correo, telefono from Usuarios WHERE idUsuario = @valor", conexion.Conectar);
                cmd.Parameters.AddWithValue("@valor", txtvalorbuscar.Text);
                adapter.SelectCommand = cmd;
                table.Rows.Clear();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
                conexion.CerrarConexion();
            }
            else if (filtro == "username")
            {
                SqlCommand cmd = new SqlCommand("Select idUsuario, username,nombre, apellido, correo, telefono from Usuarios WHERE username LIKE @valor", conexion.Conectar);
                cmd.Parameters.AddWithValue("@valor", txtvalorbuscar.Text);
                adapter.SelectCommand = cmd;
                table.Rows.Clear();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
                conexion.CerrarConexion();
            }
            else if (filtro == "nombre")
            {
                SqlCommand cmd = new SqlCommand("Select idUsuario, username,nombre, apellido, correo, telefono from Usuarios WHERE nombre LIKE @valor", conexion.Conectar);
                cmd.Parameters.AddWithValue("@valor", txtvalorbuscar.Text);
                adapter.SelectCommand = cmd;
                table.Rows.Clear();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
                conexion.CerrarConexion();
            }
            else if (filtro == "apellido")
                {
                    SqlCommand cmd = new SqlCommand("Select idUsuario, username,nombre, apellido, correo, telefono from Usuarios WHERE apellido LIKE @valor", conexion.Conectar);
                    cmd.Parameters.AddWithValue("@valor", txtvalorbuscar.Text);
                    adapter.SelectCommand = cmd;
                    table.Rows.Clear();
                    adapter.Fill(table);
                    dgvUsers.DataSource = table;
                    conexion.CerrarConexion();
                }
            else if (filtro == "correo")
            {
                SqlCommand cmd = new SqlCommand("Select idUsuario, username,nombre, apellido, correo, telefono from Usuarios WHERE correo LIKE @valor", conexion.Conectar);
                cmd.Parameters.AddWithValue("@valor", txtvalorbuscar.Text);
                adapter.SelectCommand = cmd;
                table.Rows.Clear();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
                conexion.CerrarConexion();
            }
            else if (filtro == "telefono")
            {
                SqlCommand cmd = new SqlCommand("Select idUsuario, username,nombre, apellido, correo, telefono from Usuarios WHERE telefono LIKE @valor", conexion.Conectar);
                cmd.Parameters.AddWithValue("@valor", txtvalorbuscar.Text);
                adapter.SelectCommand = cmd;
                table.Rows.Clear();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
                conexion.CerrarConexion();
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("exec VerUsuarios", conexion.Conectar);
            adapter.SelectCommand = cmd;
            table.Rows.Clear();
            adapter.Fill(table);
            dgvUsers.DataSource = table;
            conexion.CerrarConexion();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idUser == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario primero");
            }
            else
            {
                Usuario editar = new Usuario();
                //igualar variables a las demas delsiguiente formulario
                editar.txtId.Text = Convert.ToString(idUser);
                editar.txtusuario.Text = usuario;
                editar.txtcontra.Text = contraseña;
                editar.txtnombre.Text = nombre;
                editar.txtapellido.Text = apellido;
                editar.txtcorreo.Text = correo;
                editar.txttelefono.Text = telefono;
                editar.operacion = "Editar";
                editar.Show();
                this.Hide();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Usuario agregar = new Usuario();
            agregar.operacion = "Agregar";
            agregar.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (idUser == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario primero");
            }
            else
            {
               
                if (MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conexion.AbrirConexion();
                    SqlCommand cmd = new SqlCommand("exec EliminaUsuario @idUsuario", conexion.Conectar);
                    cmd.Parameters.AddWithValue("@idUsuario", idUser);

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            MessageBox.Show("Usuario Eliminado Satisfactoriamente");
                            conexion.CerrarConexion();
                            actualizar();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el usuario");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la base de datos: \n" + ex.Message);
                    }
                }
            }
        }


        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idUser = Convert.ToInt32(this.dgvUsers.SelectedRows[0].Cells[0].Value);
                usuario = this.dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
                nombre = this.dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
                apellido = this.dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
                correo = this.dgvUsers.SelectedRows[0].Cells[4].Value.ToString();
                telefono = this.dgvUsers.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void actualizar()
        {
            SqlCommand cmd = new SqlCommand("exec VerUsuarios", conexion.Conectar);
            adapter.SelectCommand = cmd;
            table.Rows.Clear();
            adapter.Fill(table);
            dgvUsers.DataSource = table;
            conexion.CerrarConexion();
        }
    }

}

