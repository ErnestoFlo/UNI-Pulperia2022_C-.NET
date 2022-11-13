using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Estas librerias nos ayudan a activar sql
using System.Data.SqlClient;
using System.Configuration;


namespace PulperiaPY
{
    public partial class FrmDetalleCompra : Form
    {
        //Llamar a la clase conexión
        Conexion conexion = new Conexion();

        public FrmDetalleCompra()
        {
            InitializeComponent();
            //Trae de la base el ultimo id del formulario anterior
            txtUltimoIdCompra.Text = ultimoValorDeCompra();
            //Llenan los dgv de la bdd
            llenarDGVProducto();
            llenarDGVDetalleCompra();
        }

        private void FrmDetalleCompra_Load(object sender, EventArgs e)
        {
            //Trae de la base el ultimo id del formulario anterior
            txtUltimoIdCompra.Text = ultimoValorDeCompra();
            //Llenan los dgv de la bdd
            llenarDGVProducto();
            llenarDGVDetalleCompra();
        }

        //Funcion para traer datos de base de datos y ponerlos en textbox
        public string ultimoValorDeCompra()
        {
            //Abrimos conexion
            conexion.AbrirConexion();
            //aca seteamos un select con el ultimo id que se ingresa en compras
            string query = "select distinct top 1 idCompra from Compra order by idCompra desc";
            SqlCommand cmd = new SqlCommand(query, conexion.Conectar);
            SqlDataReader reg = cmd.ExecuteReader();

            //si encuentra algo en la base, entra en if, si no, entra en else
            if (reg.Read())
            {
                //aca se pone el nombre de la columna que desea copiar
                return reg["idCompra"].ToString();
            }
            else
            {
                //mandamos null si no encuentra nada
                return "Null";
            }
            //cerramos conexion
            conexion.CerrarConexion();
        }

        //Trae la información correspondiente de la bdd y llena el DGV Producto
        public void llenarDGVProducto()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from ListaProducto", conexion.Conectar);
                conexion.AbrirConexion();

                cmd.ExecuteNonQuery();

                SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);

                DataTable datatable = new DataTable("Producto");

                sqladapter.Fill(datatable);
                dgvProductos.DataSource = datatable.DefaultView;
                sqladapter.Update(datatable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        //Trae la información correspondiente de la bdd y llena el DGV Detalle Compra
        public void llenarDGVDetalleCompra()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("exec ListaDetalleCompra " + txtUltimoIdCompra.Text, conexion.Conectar);
                conexion.AbrirConexion();

                cmd.ExecuteNonQuery();

                SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);

                DataTable datatable = new DataTable("DetalleCompra");

                sqladapter.Fill(datatable);
                dgvDetalleCompra.DataSource = datatable.DefaultView;
                sqladapter.Update(datatable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        //Esta función se asegura de que los texbox necesarios para las acciones
        //tengan información
        public bool VerificarDatos()
        {
            if (txtIdProducto.Text == string.Empty || txtCantidad.Text == string.Empty || txtUltimoIdCompra.Text == string.Empty || txtProducto.Text == string.Empty || txtPrecioCompra.Text == string.Empty)
            {
                MessageBox.Show("Verifique los datos solicitados", "Verificar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Esta función se asegura de que las funciones de confirmación de productos 
        //tengan información
        public bool VerificarDatosEspecial()
        {
            if (txtIdProducto.Text == string.Empty || txtCantidad.Text == string.Empty || txtUltimoIdCompra.Text == string.Empty || txtProducto.Text == string.Empty || txtPrecioCompra.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Ingresa el detalle del producto a la base de datos
        public void InsertarDetalleProducto()
        {
            int idCompra = Convert.ToInt32(txtUltimoIdCompra.Text);
            int idProducto = Convert.ToInt32(txtIdProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            double precioCompra = Convert.ToDouble(txtPrecioCompra.Text);

            try
            {
                SqlCommand cmd = new SqlCommand("InsertarDetalleCompra", conexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.AbrirConexion();

                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precioCompra", precioCompra);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        //Modifica el detalle del producto a la base de datos
        public void ModificarDetalleProducto()
        {
            int idCompra = Convert.ToInt32(txtUltimoIdCompra.Text);
            int idProducto = Convert.ToInt32(txtIdProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            double precioCompra = Convert.ToDouble(txtPrecioCompra.Text);
            int idDetalle = Convert.ToInt32(txtIdDetalle.Text);

            try
            {
                SqlCommand cmd = new SqlCommand("modificarDetalleCompra", conexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.AbrirConexion();

                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precioCompra", precioCompra);
                cmd.Parameters.AddWithValue("@idDetalleCompra", idDetalle);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        //Elimina el detalle del producto a la base de datos
        public void EliminarDetalleCompra()
        {
            int idDetalle = Convert.ToInt32(txtIdDetalle.Text);

            try
            {
                SqlCommand cmd = new SqlCommand("EliminarDetalleCompra", conexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.AbrirConexion();

                cmd.Parameters.AddWithValue("@idDetalle", idDetalle);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        //Realiza diversas funcionalidades para la configuración final de los productos
        //que se van a ingresar en el detalle
        public void ConfirmarCompra()
        {
            for (int i = 0; i < contador; i++)
            {
                if (estadoEliminado[i] == "ELIMINADO")
                {
                    Console.WriteLine("el registro " + i + " se omitió");
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Se ingreso correctamente a la confirmacion");

                        int idDetalle = Convert.ToInt32(idDetalleCompraFinal[i]);
                        int idCompra = Convert.ToInt32(idCompraFinal[i]);
                        int idProducto = Convert.ToInt32(idProductoFinal[i]);
                        int cantidad = Convert.ToInt32(cantidadFinal[i]);
                        double precioCompra = Convert.ToDouble(precioCompraFinal[i]);

                        Console.WriteLine(idDetalle);
                        Console.WriteLine(idCompra);
                        Console.WriteLine(idProducto);
                        Console.WriteLine(cantidad);
                        Console.WriteLine(precioCompra);

                        Console.WriteLine("tal");

                        Console.WriteLine(idDetalleCompraFinal[i]);
                        Console.WriteLine(idCompraFinal[i]);
                        Console.WriteLine(idProductoFinal[i]);
                        Console.WriteLine(cantidadFinal[i]);
                        Console.WriteLine(precioCompraFinal[i]);

                        SqlCommand cmd = new SqlCommand("ConfirmarDetalleCompra", conexion.Conectar);
                        cmd.CommandType = CommandType.StoredProcedure;

                        conexion.AbrirConexion();

                        cmd.Parameters.AddWithValue("@idDetalleCompra", idDetalle);
                        cmd.Parameters.AddWithValue("@idCompra", idCompra);
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@precioCompra", precioCompra);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        conexion.CerrarConexion();
                    }
                }
            }
        }

        //Limpia el texto de las casillas
        public void LimpiarCasillas()
        {
            txtCantidad.Clear();
            txtIdProducto.Clear();
            txtPrecioCompra.Clear();
            txtProducto.Clear();
            //txtUltimoIdCompra.Clear();
            txtBuscarDetalle.Clear();
            txtBuscarProducto.Clear();
        }

        //
        public string ultimoValorIdDetalleCompra()
        {
            //Abrimos conexion
            conexion.AbrirConexion();
            //Aca seteamos un select con el ultimo id que se ingresa en compras
            string query = "select distinct top 1 idDetalleCompra from DetalleCompra order by idDetalleCompra desc";
            SqlCommand cmd = new SqlCommand(query, conexion.Conectar);
            SqlDataReader reg = cmd.ExecuteReader();

            //Si encuentra algo en la base, entra en if, si no, entra en else
            if (reg.Read())
            {
                //aca se pone el nombre de la columna que desea copiar
                return reg["idDetalleCompra"].ToString();
            }
            else
            {
                //mandamos null si no encuentra nada
                return "Null";
            }
            //cerramos conexion
            conexion.CerrarConexion();
        }

        /****************************** FUNCIONES DE CONFIRMACIÓN ******************************/
        //Variables globales para el arreglo de ingresar
        string idDetalleCompraIngresar;
        string idCompraIngresar;
        string idProductoIngresar;
        string cantidadIngresar;
        string precioCompraIngresar;

        //Se usa en todo el sistema
        int contador = 0;

        //Guarda en las variables globales el último producto que es ingresado
        //en el sistema: OJO => "Lo guarda provicionalmente"
        public void arreglosIngresar()
        {

            idDetalleCompraIngresar = ultimoValorIdDetalleCompra();
            idCompraIngresar = Convert.ToString(txtUltimoIdCompra.Text);
            idProductoIngresar = Convert.ToString(txtIdProducto.Text);
            cantidadIngresar = Convert.ToString(txtCantidad.Text);
            precioCompraIngresar = Convert.ToString(txtPrecioCompra.Text);

            Console.WriteLine("Se ingreso al carro");
            LimpiarCasillas();
        }

        //Variables de función final
        string[] idDetalleCompraFinal = new string[1000];
        string[] idCompraFinal = new string[1000];
        string[] idProductoFinal = new string[1000];
        string[] cantidadFinal = new string[1000];
        string[] precioCompraFinal = new string[1000];

        //Se usa en todo el sistema
        string[] estadoEliminado = new string[1000];

        /* 
         * Por medio de esta función se guarda en una tabla imaginaria todas las inserciones
         * mientras esté abierto el módulo de detalle sin importar si si ha sido eliminada
         * o modificado. OJO => Si se cierra DetalleDeCompra esta tabla se reinicia(Queda vacía).
         */
        public void TablaFinalIngreso()
        {
            idDetalleCompraFinal[contador] = idDetalleCompraIngresar;
            Console.WriteLine(idDetalleCompraFinal[contador]);

            idCompraFinal[contador] = idCompraIngresar;
            Console.WriteLine(idCompraFinal[contador]);

            idProductoFinal[contador] = idProductoIngresar;
            Console.WriteLine(idProductoFinal[contador]);

            cantidadFinal[contador] = cantidadIngresar;
            Console.WriteLine(cantidadFinal[contador]);

            precioCompraFinal[contador] = precioCompraIngresar;
            Console.WriteLine(precioCompraFinal[contador]);

            estadoEliminado[contador] = "TABUENO UWU";

            contador++;

            Console.WriteLine("Se ingreso a la tabla final del carro");
        }

        //Variables para el arreglo de modificar
        string idCompraModificar;
        string idProductoModificar;
        string cantidadModificar;
        string precioModificar;
        string detalleModificar;

        /* Esta función se encarga de que cada vez que se modifique un dato en la bdd 
         * reorganzará el dato en la tabla imaginaria, modificando sus valores. */
        public void filtroModificar()
        {
            detalleModificar = txtIdDetalle.Text;

            idCompraModificar = txtUltimoIdCompra.Text;
            idProductoModificar = txtIdProducto.Text;
            cantidadModificar = txtCantidad.Text;
            precioModificar = txtPrecioCompra.Text;

            for (int i = 0; i <= contador; i++)
            {
                if (detalleModificar == idDetalleCompraFinal[i])
                {
                    idCompraFinal[i] = idCompraModificar;
                    idProductoFinal[i] = idProductoModificar;
                    cantidadFinal[i] = cantidadModificar;
                    precioCompraFinal[i] = precioModificar;

                    Console.WriteLine("Se modifico el producot en el carro");
                }
            }
            LimpiarCasillas();
        }

        //Variable de soporte para ver el Id del detalle de la compra
        string idDetalleCompraEliminardo;

        //Modifica el estado de un dato eliminado de la tabla imaginaria
        public void filtroEliminar()
        {
            idDetalleCompraEliminardo = txtIdDetalle.Text;

            for (int i = 0; i <= contador; i++)
            {
                if (idDetalleCompraEliminardo == idDetalleCompraFinal[i])
                {
                    estadoEliminado[i] = "ELIMINADO";
                    Console.WriteLine("Se elimino del carro");
                }
                else
                {
                    estadoEliminado[i] = "TABUENOUWU"; //Losn ingresa
                }
                LimpiarCasillas();
            }

        }

        //Ingresa los datos a la base de datos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    InsertarDetalleProducto();
                    MessageBox.Show("Producto agregado", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarDGVDetalleCompra();
                    llenarDGVProducto();

                    txtUltimoIdDetalleCompra.Text = ultimoValorIdDetalleCompra();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    llenarDGVDetalleCompra();
                    llenarDGVProducto();
                }
            }

        }

        //Modifica los datos a la base de datos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarDatos())
                {
                    ModificarDetalleProducto();
                    MessageBox.Show("Se modifico lo seleccionado", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarDGVDetalleCompra();
                    llenarDGVProducto();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                llenarDGVDetalleCompra();
                llenarDGVProducto();
            }
        }

        /* Confirma los datos que se guardarán en la BDD, es la encargada de la 
         * acción de la tabla imaginaria*/
        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea confirmar su compra?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ConfirmarCompra();
                    MessageBox.Show("Su compra a sido confirmada!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    llenarDGVDetalleCompra();
                    llenarDGVProducto();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    LimpiarCasillas();
                    llenarDGVDetalleCompra();
                    llenarDGVProducto();
                }
            }
        }

        //Elimina los datos a la base de datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar lo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (txtIdDetalle.Text == string.Empty)
            {
                MessageBox.Show("Verifique los datos solicitados", "Verificar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    EliminarDetalleCompra();
                    MessageBox.Show("Se elimino lo seleccionado", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarDGVDetalleCompra();
                    llenarDGVProducto();

                    filtroEliminar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    llenarDGVDetalleCompra();
                    llenarDGVProducto();
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtProducto.Text = row.Cells[0].Value.ToString();
                txtIdProducto.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDetalleCompra.Rows[e.RowIndex];
                txtProducto.Text = row.Cells[0].Value.ToString();
                txtCantidad.Text = row.Cells[1].Value.ToString();
                txtPrecioCompra.Text = row.Cells[2].Value.ToString();
                txtIdDetalle.Text = row.Cells[4].Value.ToString();
            }
        }

        //Filtra información de la BDD
        private void Busqueda(string Comando, DataGridView grid, string columna)
        {
            DataSet dsa = new DataSet();
            BindingSource bs = new BindingSource();
            DataTable dt = new DataTable();

            string cnn = "String connection = \"Server=tcp:gestiong1.database.windows.net,1433;Initial Catalog=pulperiaproyect;Persist Security Info=False;User ID=AdminUnicah;Password=Gestiongrup01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection SqlCon = new SqlConnection(cnn);

            SqlDataAdapter da = new SqlDataAdapter(Comando, SqlCon);

            da.Fill(dt);
            bs.DataSource = dt.DefaultView;

            grid.DataSource = bs;

            DataSet ds = new DataSet();
            ds.Tables.Add(dt.Copy());

            DataView dv = new DataView(ds.Tables[0]);

            dv.RowFilter = columna;

            if (dv.Count != 0)
            {
                grid.DataSource = dv;
            }
            else
            {
                grid.DataSource = null;
            }

        }

        //Filtra la información de los productos
        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            Busqueda("exec BuscarProductosCompras ", dgvProductos, "Nombre LIKE '%" + txtBuscarProducto.Text + "%'");
        }

        //Filtra la información de DetalleProducto
        private void txtBuscarDetalle_TextChanged(object sender, EventArgs e)
        {
            Busqueda("exec ListaDetalleCompra " + txtUltimoIdCompra.Text, dgvDetalleCompra, "Producto LIKE '%" + txtBuscarDetalle.Text + "%'");
        }

        //Activa la primera funcionalidad de la tabla imaginaria 
        private void btnIngresar_MouseUp(object sender, MouseEventArgs e)
        {
            if (VerificarDatosEspecial())
            {
                arreglosIngresar();
                TablaFinalIngreso();
            }
        }

        //Se activa en el caso de modificar en la tabla imaginaria
        private void btnModificar_MouseUp(object sender, MouseEventArgs e)
        {
            if (VerificarDatosEspecial())
            {
                filtroModificar();
            }

        }
    }
}
