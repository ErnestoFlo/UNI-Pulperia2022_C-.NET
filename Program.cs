using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PulperiaPY
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new FrmProveedor());
=======
            Application.Run(new Bitacora());
>>>>>>> bitacora
=======
            Application.Run(new FrmCompra());
>>>>>>> compra
=======
            Application.Run(new Inventario());
>>>>>>> inventario
=======
            Application.Run(new Producto());
>>>>>>> producto
        }
    }
}
