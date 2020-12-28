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


        public void Editar(Preferencia preferencia) {

            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                try
                {
                    var preferencia_aux = preferencias.Query().First();
                    preferencia_aux.Ganancia = preferencia.Ganancia;
                    preferencia_aux.GananciaCigarrillo = preferencia.GananciaCigarrillo;
                    preferencia_aux.GananciaCredito = preferencia.GananciaCredito;
                    preferencia_aux.GananciaDebito = preferencia.GananciaDebito;
                    preferencias.Update(preferencia_aux);
                }
                catch {
                    preferencias.Insert(preferencia);
                }
                
            }
        }

        public bool existePteferencia() {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                try
                {
                    preferencias.Query().First();
                    return true;
                }
                catch {
                    return false;
                }
               
            }
        }

        public Preferencia getPreferencia() {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                return preferencias.Query().First();
            }

        }
    }
}
