using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Todo_en_uno.Helpers;

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

        public static List<Producto> GetProductos()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var productos = db.GetCollection<Producto>("productos");
                return productos.Query().ToList();
            }
        }
    }
}
