using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulperiaPY.Utilidades
{
    internal class clsVariableGlobales
    {
        public static string codigoProductoV;
        public static string nombreProductoV;
        public static decimal precioProductoV;
        public static int stockProductoV;

        public static string CodigoProductoV { get => codigoProductoV; set => codigoProductoV = value; }
        public static string NombreProductoV { get => nombreProductoV; set => nombreProductoV = value; }
        public static decimal PrecioProductoV { get => precioProductoV; set => precioProductoV = value; }
        public static int StockProductoV { get => stockProductoV; set => stockProductoV = value; }
    }
}
