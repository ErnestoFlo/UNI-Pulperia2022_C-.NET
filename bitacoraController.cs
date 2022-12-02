using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using static PulperiaPY.Conexion;
namespace PulperiaPY
{
    class bitacoraController
    {
        public Conexion conn;
        public bitacoraController()
        {
            conn = new Conexion();

        }
        public DataTable getBitacora(int userId = 0, string ActionType = "None")
        {
            conn.AbrirConexion();
            SqlCommand command = new SqlCommand("getBitacora",conn.Conectar);
            command.CommandType = CommandType.StoredProcedure;
            if (userId != 0)
            {
                command.Parameters.AddWithValue("userId", userId);
            }
     
            if (ActionType != "None")
            command.Parameters.AddWithValue("actionType", ActionType);
            SqlDataReader dataReader = command.ExecuteReader();
           
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            conn.CerrarConexion();
            return dataTable;

        }
        public DataTable getUsers()
        {
            conn.AbrirConexion();
            SqlCommand command = new SqlCommand("VerUsuarios", conn.Conectar);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dataReader = command.ExecuteReader();
            
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            conn.CerrarConexion();
            return dataTable;
        }
    }
}
