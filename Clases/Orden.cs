using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_en_uno.Clases;
using Todo_en_uno.Helpers;

namespace Todo_en_uno.Clases
{
    class Orden
    {
        public int Id { get; set; }
        public String codigo { get; set; }
        public String nombreProducto { get; set; }
        public bool esCigarrillo { get; set; }
        public double precio { get; set; }
        public int cantProducto { get; set; }


        public void cargarOrden(double? precioEntrada, string codigo, int cantProducto, bool esVentaPropia)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                var productos = db.GetCollection<Producto>("productos");
                var producto_aux = productos.Query()
                .Where(x => x.Codigo.Equals(codigo))
                .ToList().First();
               
                if (precioEntrada == null )
                {
                    if (esVentaPropia)
                    {
                        var orden = new Orden
                        {
                            codigo = producto_aux.Codigo,
                            esCigarrillo = producto_aux.EsCigarrillo,
                            nombreProducto = producto_aux.Nombre,
                            precio = producto_aux.PrecioBase,
                            cantProducto = cantProducto
                        };
                        ordenes.Insert(orden);
                    }
                    else
                    {
                        var orden = new Orden
                        {
                            codigo = producto_aux.Codigo,
                            esCigarrillo = producto_aux.EsCigarrillo,
                            nombreProducto = producto_aux.Nombre,
                            precio = producto_aux.PrecioVenta,
                            cantProducto = cantProducto
                        };
                        ordenes.Insert(orden);
                    }
                }
                else
                {
                    var orden = new Orden
                    {
                        codigo = producto_aux.Codigo,
                        esCigarrillo = producto_aux.EsCigarrillo,
                        nombreProducto = producto_aux.Nombre,
                        precio = Convert.ToDouble(precioEntrada),
                        cantProducto = cantProducto
                    };
                    ordenes.Insert(orden);
                }
            }
        }
        public void eliminarOrden()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                ordenes.DeleteAll();
            }
        }
        public List<Orden> getAll()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                return ordenes.Query().ToList();
            }
        }
    }
}
