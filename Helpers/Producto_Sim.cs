using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_en_uno.Helpers
{
    class Producto_Sim
    {
        public string Nombre { get; set; }
        public double PrecioBase { get; set; }
        public int StockFaltante { get; set; }
        public double Costo { get; set; }

        public Producto_Sim(string n, double pb, int stock)
        {
            Nombre = n;
            PrecioBase = pb;
            StockFaltante = stock;
            Costo = Math.Round(pb * stock, 2, MidpointRounding.AwayFromZero);
        }
    }
}
