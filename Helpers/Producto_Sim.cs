using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_en_uno.Helpers
{
    public class Producto_Sim
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioBase { get; set; }
        public int StockFaltante { get; set; }
        public double Costo { get; set; }

        public Producto_Sim(int id, string n, double pb, int stock)
        {
            Id = id;
            Nombre = n;
            PrecioBase = pb;
            StockFaltante = stock;
            Costo = Math.Round(pb * stock, 2, MidpointRounding.AwayFromZero);
        }
    }
}
