using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PulperiaPY
{
    public partial class FrmProveedor : Form
    {
        // Instancia clase de conexión
        Conexion conexionDb = new Conexion();
        // Variable para establecer el estado de el proveedor
        public int estadoBit { get; set; }
        public FrmProveedor()
        {
            // Se inicializa el componente del form
            InitializeComponent();
            // Se cargan los proveedores en el datagridview
            CargarProveedores();
        }

        // Función para cargar los proveedores activos en el datagridview
        private void CargarProveedores()
        {
            // Ejecuta la función creada en la conexión para llenar el datagridview
            conexionDb.llenarDGV(dgvProveedores, "Execute verProveedoresACT");
        }

        // Función para cargar los proveedores inactivos en el datagridview
        private void CargarProveedoresIna()
        {
            // Ejecuta la función creada en la conexión para llenar el datagridview
            conexionDb.llenarDGV(dgvProveedores, "Execute verProveedoresINA");
        }

        // Función para cargar todos los proveedores en el datagridview
        private void CargarTodosProveedores()
        {
            // Ejecuta la función creada en la conexión para llenar el datagridview
            conexionDb.llenarDGV(dgvProveedores, "Execute verTodosProveedores");
            // cambia el elemento seleccionado en el combobox de visualización
            cmbFiltroProv.SelectedIndex = 2;
        }

        // Función para limpiar los textbox
        private void limpiarSel()
        {
            foreach (Control c in this.Controls)
            {

                if (c is System.Windows.Forms.TextBox)

                {

                    c.Text = "";

                    //Enfoco en el primer TextBox

                    this.txbIdProv.Focus();

                }

            }
            cmbEstProv.SelectedIndex = 0;
        }

        // Evento Load del formulario
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            // se igualan las selecciones de los combobox a su posición predeterminada
            cmbEstProv.SelectedIndex = 0;
            cmbFiltroProv.SelectedIndex = 2;
        }

        // Evento click de botón AÑADIR
        private void btnAddProv_Click(object sender, EventArgs e)
        {
            // Se especifica lo que dirá el mensaje
            string message = "¿Está seguro que desea insertar el proveedor?";
            // Se especifica el título del mensaje
            string caption = "Comprobación";
            // Se indican las opciones disponibles
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            // Se evalua el resultado
            DialogResult result;

            // Se realiza una condición en la que el id debe estar vacio
            if (txbIdProv.Text != "")
            {
                // Se envia en el mensaje deseado
                MessageBox.Show("El proveedor ya se encuentra insertado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            // sino se condiciona que los datos a actualizar esten siendo ingresados
            else if (txbNameProv.Text != "" && txbTelProv.Text != "" && txbDirProv.Text != "" && cmbEstProv.SelectedIndex != 0)
            {
                // se declaran las variables para obtener en strings los textbox
                string nombreProov = string.Format(txbNameProv.Text);
                string telefono = string.Format(txbTelProv.Text);
                string direccion = string.Format(txbDirProv.Text);

                // Iguala el resultado a el messageBox
                result = MessageBox.Show(message, caption, buttons);
                // Evalua el resultado del messageBox
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Realiza una condición en la conexión para comprobar que se realice la inserción en la base
                    if (conexionDb.ejecutarComandoSQL("Execute crearProveedor '" + nombreProov + "' , '" + telefono + "' , '" + direccion + "', '" + estadoBit + "' "))
                    {
                        // Muestra el mensaje deseado
                        MessageBox.Show("Proveedor insertado correctamente", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Llama la función para cargar nuevamente los proveedores
                        CargarTodosProveedores();
                    }
                    else
                    {
                        // Muestra el mensaje deseado
                        MessageBox.Show("Error al insertar proveedor", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Llama la función de limpiar textbox
                    limpiarSel();
                }
            }
            else
            {
                // Muestra el mensaje deseado
                MessageBox.Show("Ingrese los datos solicitados", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento click en el contenido de un registro de la tabla de proveedores
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se Intenta lo solicitado si falla muestra un mensaje
            try
            {
                //Iguala cada textbox a la celda seleccionada del datagridview
                txbIdProv.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                txbNameProv.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
                txbTelProv.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                txbDirProv.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();

                // Se hace una conversión del estado del proveedor
                string valorCel = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
                bool numCel = Convert.ToBoolean(valorCel);
                
                // se valida si es activo o inactivo
                if (numCel)
                {
                    cmbEstProv.SelectedIndex = 1;
                }
                else
                {
                    cmbEstProv.SelectedIndex = 2;
                }
            }
            catch
            {
                // Muestra el mensaje deseado
                MessageBox.Show("Error al seleccionar proveedor", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCleProv_Click(object sender, EventArgs e)
        {
            // Llama la función para limpiar los textbox
            limpiarSel();
        }

        // Evento click en el botón ACTUALIZAR
        private void btnUpdProv_Click(object sender, EventArgs e)
        {
            // Se declaran las variables necesarias
            string nombreProov = string.Format(txbNameProv.Text);
            string telefono = string.Format(txbTelProv.Text);
            string direccion = string.Format(txbDirProv.Text);

            // Se especifica lo que dirá el mensaje
            string message = "¿Está seguro que desea actualizar el proveedor?";
            // Se especifica el título del mensaje
            string caption = "Comprobación";
            // Se especifica el título del mensaje
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            // Se evalua el resultado
            DialogResult result;

            // Condicional que verifica que todos los campos esten llenos
            if (txbNameProv.Text != "" && txbTelProv.Text != "" && txbDirProv.Text != "" && cmbEstProv.SelectedIndex != 0)
            {
                // Conversión de string id a int
                int idProv = Int32.Parse(txbIdProv.Text);
                // Muestra el combobox
                result = MessageBox.Show(message, caption, buttons);

                // Verifica la respuesta del usuario
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Condicional que verifica la ejecución del comando sql de actualización
                    if (conexionDb.ejecutarComandoSQL("Execute actualizarProveedor '" + idProv + "' , '" + nombreProov + "' , '" + telefono + "' , '" + direccion + "', '" + estadoBit + "' "))
                    {
                        // Muestra el mensaje deseado
                        MessageBox.Show("Proveedor actualizado correctamente", "Actualizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Carga los proveedores en el datagridview
                        CargarTodosProveedores();
                    }
                    else
                    {
                        // Muestra el mensaje deseado
                        MessageBox.Show("Error al actualizar proveedor", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Limpia los textbox
                    limpiarSel();
                }
            }
            else
            {
                // Muestra el mensaje deseado
                MessageBox.Show("Ingrese los datos solicitados", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento click en botón de BUSCAR
        private void btnSearProv_Click(object sender, EventArgs e)
        {
            // Se obtiene el texto de la selección del combobox
            string estadoFil = cmbFiltroProv.Text;

            // Se valida que haya ingresado un valor a buscar y la opción seleccionada
            if (txbSearProv.Text != "" && estadoFil == "Activos")
            {
                // Se convierte el texto a un formato de string
                string nombreProov = string.Format(txbSearProv.Text);

                // Se valida si se realizo la busqueda en la base de datos
                if (!conexionDb.llenarDGV(dgvProveedores, "Execute buscarProveedor '" + nombreProov + "'"))
                {
                    // Muestra el mensaje deseado
                    MessageBox.Show("Error al buscar proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Se valida que haya ingresado un valor a buscar y la opción seleccionada
            else if (txbSearProv.Text != "" && estadoFil == "Inactivos")
            {
                // Se convierte el texto a un formato de string
                string nombreProov = string.Format(txbSearProv.Text);
                // Se valida si se realizo la busqueda en la base de datos
                if (!conexionDb.llenarDGV(dgvProveedores, "Execute buscarProveedorIna '" + nombreProov + "'"))
                {
                    // Muestra el mensaje deseado
                    MessageBox.Show("Error al buscar proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Se valida que haya ingresado un valor a buscar y la opción seleccionada
            else if (txbSearProv.Text != "" && estadoFil == "Todos")
            {
                // Se convierte el texto a un formato de string
                string nombreProov = string.Format(txbSearProv.Text);
                // Se valida si se realizo la busqueda en la base de datos
                if (!conexionDb.llenarDGV(dgvProveedores, "Execute buscarProveedorAll '" + nombreProov + "'"))
                {
                    // Muestra el mensaje deseado
                    MessageBox.Show("Error al buscar proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Muestra el mensaje deseado
                MessageBox.Show("Ingrese un nombre del proveedor", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento que se genera cuando cambia de selección combobox del estado del proveedor
        private void cmbEstProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se iguala la variable al texto de la opción seleccionada
            string estado = cmbEstProv.Text;

            // Se valida si es activo o inactivo
            if (estado == "Activo")
            {
                // se asigna ese valor a la variable de estadoBit
                estadoBit = 1;
            }
            else
            {
                // se asigna ese valor a la variable de estadoBit
                estadoBit = 0;
            }
        }

        private void btnDelProve_Click(object sender, EventArgs e)
        {
            // Se especifica lo que dirá el mensaje
            string message = "¿Está seguro que desea eliminar el proveedor?";
            // Se especifica el título del mensaje
            string caption = "Comprobación";
            // Se especifica el título del mensaje
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            // Se evalua el resultado
            DialogResult result;

            if (txbIdProv.Text != "")
            {
                if (cmbEstProv.SelectedIndex != 2)
                {
                    int idProv = Int32.Parse(txbIdProv.Text);
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Valida el valor del estado
                        if (estadoBit != 0)
                        {
                            if (conexionDb.ejecutarComandoSQL("Execute eliminarProveedor '" + idProv + "'"))
                            {
                                // Muestra el mensaje deseado
                                MessageBox.Show("Proveedor eliminado correctamente", "Eliminado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Carga los proveedores en el datagridview
                                CargarTodosProveedores();
                            }
                            else
                            {
                                // Muestra el mensaje deseado
                                MessageBox.Show("Error al eliminar proveedor", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            // Limpia los textbox
                            limpiarSel();
                        }

                    }

                }
                else
                {
                    // Muestra el mensaje deseado
                    MessageBox.Show("El proveedor ya se encuentra eliminado", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Muestra el mensaje deseado
                MessageBox.Show("Seleccione un proveedor", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFiltroProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSearProv.Text = "";
            int estadoFil = cmbFiltroProv.SelectedIndex;

            if (estadoFil == 0)
            {
                // Carga los proveedores en el datagridview
                CargarProveedores();
            }
            else if (estadoFil == 1)
            {
                // Carga los proveedores en el datagridview
                CargarProveedoresIna();
            }
            else
            {
                // Carga los proveedores en el datagridview
                CargarTodosProveedores();
            }
        }

        // Acciones de los botones segun el diseño
        private void txbTelProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbNameProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddProv_MouseHover(object sender, EventArgs e)
        {
            btnAddProv.ForeColor = Color.White;
        }

        private void btnUpdProv_MouseHover(object sender, EventArgs e)
        {
            btnUpdProv.ForeColor = Color.White;
        }

        private void btnAddProv_MouseLeave(object sender, EventArgs e)
        {
            btnAddProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnUpdProv_MouseLeave(object sender, EventArgs e)
        {
            btnUpdProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnDelProve_MouseLeave(object sender, EventArgs e)
        {
            btnDelProve.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnDelProve_MouseHover(object sender, EventArgs e)
        {
            btnDelProve.ForeColor = Color.White;
        }

        private void btnCleProv_MouseHover(object sender, EventArgs e)
        {
            btnCleProv.ForeColor = Color.White;
        }

        private void btnCleProv_MouseLeave(object sender, EventArgs e)
        {
            btnCleProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void btnSearProv_MouseHover(object sender, EventArgs e)
        {
            btnSearProv.ForeColor = Color.White;
        }

        private void btnSearProv_MouseLeave(object sender, EventArgs e)
        {
            btnSearProv.ForeColor = Color.FromArgb(32, 43, 76);
        }

        private void txbSearProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
