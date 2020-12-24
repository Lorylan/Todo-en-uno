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


        public void cargarOrden(string codigo, int cantProducto, bool esVentaPropia)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                var orden_aux = ordenes.Find(x => x.codigo == codigo && x.cantProducto > 0).FirstOrDefault();
                if (orden_aux!= null)
                {
                    orden_aux.cantProducto = orden_aux.cantProducto + cantProducto;
                    ordenes.Update(orden_aux);
                }
                else {
                    
                    var productos = db.GetCollection<Producto>("productos");
                    var producto = productos.Find(x => x.Codigo == codigo).FirstOrDefault();
                    if (esVentaPropia)
                    {
                        var orden = new Orden
                        {
                            codigo = producto.Codigo,
                            esCigarrillo = producto.EsCigarrillo,
                            nombreProducto = producto.Nombre,
                            precio = producto.PrecioBase,
                            cantProducto = cantProducto
                        };
                        ordenes.Insert(orden);
                    }
                    else
                    {
                        var orden = new Orden
                        {
                            codigo = producto.Codigo,
                            esCigarrillo = producto.EsCigarrillo,
                            nombreProducto = producto.Nombre,
                            precio = producto.PrecioVenta,
                            cantProducto = cantProducto
                        };
                        ordenes.Insert(orden);
                    }
                }
                
            }
        }
        public void cargarOrdenConPrecio(double precioEntrada, string codigo, bool esVentaPropia)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                var orden_aux = ordenes.Find(x => x.codigo == codigo && x.cantProducto == 0).FirstOrDefault();
                if (orden_aux != null)
                {
                    orden_aux.precio = orden_aux.precio + precioEntrada;
                    ordenes.Update(orden_aux);
                }
                else {
                    var productos = db.GetCollection<Producto>("productos");
                    var producto = productos.Find(x => x.Codigo == codigo).FirstOrDefault();
                    var orden = new Orden
                    {
                        codigo = producto.Codigo,
                        esCigarrillo = producto.EsCigarrillo,
                        nombreProducto = producto.Nombre,
                        precio = Convert.ToDouble(precioEntrada)
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
        public void actualualizar(int id, int cantProducto)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                var orden = ordenes.FindById(id);
                orden.cantProducto = cantProducto;
                ordenes.Update(orden);
            }
        }
        public Orden FindId(int id)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                return ordenes.FindById(id);
            }
        }
        public void elimanar(int id) {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ordenes = db.GetCollection<Orden>("ordenes");
                ordenes.Delete(id); 
            }
        }
    }
}