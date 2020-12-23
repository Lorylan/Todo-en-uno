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

        public static List<Producto> GetProductosFiltrados(string nombre, string codigo, bool stock_min)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var productos = db.GetCollection<Producto>("productos");
                var resul = productos.Query().Where(x => x.Codigo.Contains(codigo) && x.Nombre.Contains(nombre)).ToList();
                if (stock_min)
                {
                    resul = resul.Where(x => x.StockActual < x.StockMinimo).ToList();
                }
                return resul;
            }
        }
    }
}
