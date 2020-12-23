using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_en_uno.Helpers;
using Todo_en_uno.Clases;

namespace Todo_en_uno.Clases
{
    class Venta
    {
        public double PrecioTotal { get; set; }
        public double PrecioTotalCigarrillo { get; set; }
        public int CantCigarrillos { get; set; }

        public void cargarVenta()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                var preferencia = preferencias.Query().ToList().First();
                var ventas = db.GetCollection<Venta>("ventas");
                var venta = new Venta
                {
                    PrecioTotal = this.PrecioTotal*(preferencia.Ganancia/100),
                    PrecioTotalCigarrillo = CantCigarrillos*preferencia.GananciaCigarrillo,
                    CantCigarrillos = this.CantCigarrillos
                };
                ventas.Insert(venta);
            }
        }
        public double calcularCredito()
        {
            Preferencia preferencia_aux;
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                preferencia_aux = preferencias.Query().ToList().First();
            }
            return (PrecioTotal + PrecioTotalCigarrillo) * (preferencia_aux.GananciaCredito / 100);
        }
        public double calcularDebito()
        {
            Preferencia preferencia_aux;
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                preferencia_aux = preferencias.Query().ToList().First();
            }
            return PrecioTotal + (PrecioTotalCigarrillo * (1+(preferencia_aux.GananciaDebito/100)));
        }
        public void calcularPrecio() {
            double ganancia;
            double gananciaCigarrillo;
            PrecioTotal = 0;
            CantCigarrillos = 0;
            PrecioTotalCigarrillo = 0;
            List<Orden> ordenes;
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                var preferencia_aux = preferencias.Query().ToList().First();
                ganancia = preferencia_aux.Ganancia;
                gananciaCigarrillo = preferencia_aux.GananciaCigarrillo;
                var list_ordenes = db.GetCollection<Orden>("ordenes");
                ordenes = list_ordenes.Query().ToList();
            }
            foreach (Orden orden in ordenes) {
                if (orden.esCigarrillo)
                {
                    CantCigarrillos++;
                    PrecioTotalCigarrillo += orden.precio;
                }
                else {
                    PrecioTotal += orden.precio;
                }
            }
        }
    }
}
