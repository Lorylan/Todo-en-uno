using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_en_uno.Clases
{
    public class Venta
    {
        public List<Productos> List_productos{ get; set; }
        public Boolean Cerrada;

        public Venta() {
            Cerrada = false;
            List_productos = new List<Productos>();
        }

        public void agregar_producto(Producto p) { 
            //implementar el agregar venta
        }
    }

}
