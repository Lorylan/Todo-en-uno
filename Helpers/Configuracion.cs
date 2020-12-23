using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_en_uno.Helpers
{
    class Configuracion
    {
        public static String rutaBaseDeDatos
        {
            get
            {
                string rutaProyecto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                return rutaProyecto + "\\Db\\TodoEnUnoDb.db";
            }
        }
    }
}
