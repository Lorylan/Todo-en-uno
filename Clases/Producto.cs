using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_en_uno.Clases
{
    class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioBase { get; set; }
        public double PrecioVenta { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public string Codigo { get; set; }
        public Boolean EsCigarrillo { get; set; }
    }
}
