using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PulperiaPY.CapaDatos
{
    class conexion2
    {
        static private string CadenaConexion = "Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection Conexion2 = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (Conexion2.State == ConnectionState.Closed)
                Conexion2.Open();
            return Conexion2;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion2.State == ConnectionState.Open)
                Conexion2.Close();
            return Conexion2;
        }
    }
}
