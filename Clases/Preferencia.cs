using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_en_uno.Helpers;

namespace Todo_en_uno.Clases
{
    class Preferencia
    {
        public int Id { get; set; }
        public double Ganancia { set; get; }
        public double GananciaCigarrillo { set; get; }
        public double GananciaDebito { set; get; }
        public double GananciaCredito { get; set; }

    }
}
