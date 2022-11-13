using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PulperiaPY.CapaDatos
{
    class ClsProductos
    {
        private conexion2 Conexion2 = new conexion2();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        private int IdInventario;
        private int IdProducto;
        private int CantidadDisponible;

        //metodos get y set
        public int _IdInven
        {
            get { return IdInventario; }
            set { IdInventario = value; }
        }
        public int _IdProd
        {
            get { return IdProducto; }
            set { IdProducto = value; }
        }
        public int _CantiDis
        {
            get { return CantidadDisponible; }
            set { CantidadDisponible = value; }
        }

        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion2.AbrirConexion();
            Comando.CommandText = "ListarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion2.CerrarConexion();
            return Tabla;
        }

        public void InsertarInventario(int idProducto, int CantidadDisponible)
        {
            Comando.Connection = Conexion2.AbrirConexion();
            Comando.CommandText = "InsertarInventario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idProducto", idProducto);
            Comando.Parameters.AddWithValue("@CantidadDisponible", CantidadDisponible);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion2.CerrarConexion();
        }

        public DataTable ListarInventario()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion2.AbrirConexion();
            Comando.CommandText = "ListarInventario";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion2.CerrarConexion();
            return Tabla;
        }
    }
}
