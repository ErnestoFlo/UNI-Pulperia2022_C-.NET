using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PulperiaPY
{
    class Conexion
    {
<<<<<<< HEAD
        String connection = "Data Source=DESKTOP-NQIVP0D; Initial Catalog = pulperiaproyect; Integrated Security= True";
        //String connection = "Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

=======
        //String connection = "Data Source=(local)\\SQLEXPRESS; Initial Catalog = pulperiaHermanos; Integrated Security= True";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        String connection = "Server=tcp:gestiong1.database.windows.net,1433;Database=pulperiaproyect;User ID=AdminUnicah;Password=Gestiongrup01;Trusted_Connection=False;Encrypt=True;";
>>>>>>> bitacora
=======
        public String connection = "Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
>>>>>>> inventario
=======
        String connection = "Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
>>>>>>> login
=======
        public String connection = "Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
>>>>>>> producto
        public SqlConnection Conectar = new SqlConnection();
        public SqlDataAdapter adaptador;
        public DataTable tablaDatos;
        public SqlDataReader lectorVariables;
        public SqlCommand comando;

        public Conexion(){
=======
        String connection = "Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection Conectar = new SqlConnection();
        public Conexion()
        {
>>>>>>> compra
            Conectar.ConnectionString = connection;
        }

        public void AbrirConexion()
        {
            try
            {
                this.Conectar.Open();
                Console.WriteLine("Conexion Exitosa!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Existió un error al abrir conexión :", e.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                Conectar.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Existió un error al cerrar conexión:", e.Message);
            }
        }

        //Metodo enviar COMANDOS SQL donde se quiera hacer operaciones de SELECT, INSERT, DELETE, UPDATE, (se envia comando SQL)     [RETORNA null SI HAY UN ERROR DE EJECUCION]
        public bool ejecutarComandoSQL(string instruccion)
        {
            try
            {
                Conectar.Open();
                comando = new SqlCommand(instruccion, Conectar);
                if (comando.ExecuteNonQuery() != -1)
                {
                    Conectar.Close();
                    return true;
                }
                else
                {
                    Conectar.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                Conectar.Close();
                MessageBox.Show("Error al ejecutar comando SQL. " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        //Agrega informacion de una consulta SQL a un datagridview
        public bool llenarDGV(DataGridView dgv, string instruccion)
        {
            try
            {
                Conectar.Open();
                adaptador = new SqlDataAdapter(instruccion, Conectar);
                tablaDatos = new DataTable();
                adaptador.Fill(tablaDatos);
                dgv.DataSource = tablaDatos;
                Conectar.Close();
                return true;
            }
            catch (Exception)
            {
                Conectar.Close();
                MessageBox.Show("Error en la conexión");
                return false;
            }
            finally { Conectar.Close(); }
        }
    }
}
