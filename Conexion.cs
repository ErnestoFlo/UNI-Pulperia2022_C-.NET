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
        //String connection = "Data Source=(local)\\SQLEXPRESS; Initial Catalog = pulperiaHermanos; Integrated Security= True";
        public String connection = "Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection Conectar = new SqlConnection();
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
    }
}
