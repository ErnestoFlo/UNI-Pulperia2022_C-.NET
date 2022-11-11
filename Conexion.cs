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
        String connection = "Data Source=(local)\\SQLEXPRESS; Initial Catalog = pulperiaproyect; Integrated Security= True";
        //String connection = "Server=tcp:pulperia.database.windows.net,1433;Initial Catalog=GrupoClinica;Persist Security Info=False;User ID=administrador;Password=Pulperia2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection Conectar = new SqlConnection();
        public SqlDataAdapter adaptador;
        public DataTable tablaDatos;
        public SqlDataReader lectorVariables;
        public SqlCommand comando;
        public Conexion(){
            Conectar.ConnectionString = connection;
        }

        public void AbrirConexion()
        {
            try
            {
                Conectar.Open();
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
                MessageBox.Show("Error en la conexión! "+ e.Message, "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Agrega informacion de una consulta SQL a un DataTable
        public DataTable llenarDT(string instruccion)
        {
            try
            {
                Conectar.Open();
                adaptador = new SqlDataAdapter(instruccion, Conectar);
                tablaDatos = new DataTable();
                adaptador.Fill(tablaDatos);
                Conectar.Close();
                return tablaDatos;
            }
            catch (Exception)
            {
                Conectar.Close();
                MessageBox.Show("Error en la conexión");
                return null;
            }
            finally { Conectar.Close(); }
        }

        //Metodo para obtener variables INT de la base de datos. (Se envia el comando sql) de donde se quiere obtener la variable [RETORNA -1 SI NO ENCUENTRA UN VALOR]
        public int obtenerVariableEntera(string instruccion)
        {
            try
            {
                Conectar.Open();
                int valor = 0;
                comando = new SqlCommand(instruccion, Conectar);
                lectorVariables = comando.ExecuteReader();
                if (lectorVariables.Read())
                {
                    valor = Convert.ToInt16(lectorVariables.GetValue(0));
                }
                lectorVariables.Close();
                Conectar.Close();
                return valor;
            }
            catch (Exception)
            {
                Conectar.Close();
                MessageBox.Show("Error en la conexión");
                return -1;
            }
            finally { Conectar.Close(); }
        }        //Metodo para obtener variables DECIMAL de la base de datos. (Se envia el comando sql) de donde se quiere obtener la variable [RETORNA -1 SI NO ENCUENTRA UN VALOR]
        public decimal obtenerVariableDecimal(string instruccion)
        {
            try
            {
                Conectar.Open();
                decimal valor = 0;
                comando = new SqlCommand(instruccion, Conectar);
                lectorVariables = comando.ExecuteReader();
                if (lectorVariables.Read())
                {
                    valor = Convert.ToDecimal(lectorVariables.GetValue(0));
                }
                lectorVariables.Close();
                Conectar.Close();
                return valor;
            }
            catch (Exception)
            {
                Conectar.Close();
                MessageBox.Show("Error en la conexión");
                return -1;
            }
            finally { Conectar.Close(); }
        }
    }
}
