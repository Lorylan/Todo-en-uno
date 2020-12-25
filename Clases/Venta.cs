﻿using LiteDB;
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
        public bool esVentaPropia { get; set; }

        public DateTime Fecha { get; set; }
        public List<Venta> getAll()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ventas = db.GetCollection<Venta>("ventas");
                return ventas.Query().ToList();
            }
        }
        public void actualizarStock()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var list_ordenes = db.GetCollection<Orden>("ordenes");
                var productos = db.GetCollection<Producto>("productos");
                List<Orden> ordenes = list_ordenes.Query().ToList();
                foreach (Orden orden in ordenes) {
                    var producto = productos.Find(x => x.Codigo == orden.codigo).FirstOrDefault();
                    if (producto.StockActual - orden.cantProducto < 0)
                    {
                        producto.StockActual = 0;
                    }
                    else {
                        producto.StockActual = producto.StockActual - orden.cantProducto;
                    }
                    productos.Update(producto);
                }
            }
        }
        public void cargarVenta(bool esVentaPropia)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ventas = db.GetCollection<Venta>("ventas");
                var venta = new Venta
                {
                    PrecioTotal = this.PrecioTotal,
                    PrecioTotalCigarrillo = this.PrecioTotalCigarrillo ,
                    CantCigarrillos = this.CantCigarrillos,
                    Fecha = DateTime.Now,
                    esVentaPropia = esVentaPropia
                };
                ventas.Insert(venta);
            }
        }
        public double calcularCredito(bool esVentaPropia)
        {
            if (esVentaPropia) {
                return 0;
            }
            else{
                Preferencia preferencia_aux;
                using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
                {
                    var preferencias = db.GetCollection<Preferencia>("preferencias");
                    preferencia_aux = preferencias.Query().ToList().First();
                }
                double total = (PrecioTotal + PrecioTotalCigarrillo) * (1 + (preferencia_aux.GananciaCredito / 100));
                return total;
            }
            
        }
        public double calcularDebito(bool esVentaPropia)
        {
            if (esVentaPropia)
            {
                return 0;
            }
            else {
                Preferencia preferencia_aux;
                using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
                {
                    var preferencias = db.GetCollection<Preferencia>("preferencias");
                    preferencia_aux = preferencias.Query().ToList().First();
                }
                double porcentaje = 1 + (preferencia_aux.GananciaDebito / 100);
                double total = (PrecioTotal + (PrecioTotalCigarrillo * porcentaje));
                return total;
            }
            
        }
        public Venta getVentasHoyPropia() {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ventas = db.GetCollection<Venta>("ventas");
                List<Venta> ventasHoy = ventas.Find(x => x.Fecha.Date == DateTime.Now.Date && x.esVentaPropia).ToList();

                Venta sumatoriaVenta = new Venta();
                sumatoriaVenta.CantCigarrillos = 0;
                sumatoriaVenta.PrecioTotal = 0;
                sumatoriaVenta.PrecioTotalCigarrillo = 0;
                foreach (Venta v in ventasHoy) {
                    sumatoriaVenta.CantCigarrillos += v.CantCigarrillos;
                    sumatoriaVenta.PrecioTotal += v.PrecioTotal;
                    sumatoriaVenta.PrecioTotalCigarrillo += v.PrecioTotalCigarrillo;
                }
                return sumatoriaVenta;
            }
        }
        public Venta getVentasMesPropia()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ventas = db.GetCollection<Venta>("ventas");
                List<Venta> ventasHoy = ventas.Find(x => x.Fecha.Date.Month == DateTime.Now.Date.Month && x.esVentaPropia && x.Fecha.Date.Year == DateTime.Now.Date.Year).ToList();

                Venta sumatoriaVenta = new Venta();
                sumatoriaVenta.CantCigarrillos = 0;
                sumatoriaVenta.PrecioTotal = 0;
                sumatoriaVenta.PrecioTotalCigarrillo = 0;
                foreach (Venta v in ventasHoy)
                {
                    sumatoriaVenta.CantCigarrillos += v.CantCigarrillos;
                    sumatoriaVenta.PrecioTotal += v.PrecioTotal;
                    sumatoriaVenta.PrecioTotalCigarrillo += v.PrecioTotalCigarrillo;
                }
                return sumatoriaVenta;
            }
        }
        public Venta getVentasHoy()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ventas = db.GetCollection<Venta>("ventas");
                List<Venta> ventasHoy = ventas.Find(x => x.Fecha.Date == DateTime.Now.Date && x.esVentaPropia).ToList();

                Venta sumatoriaVenta = new Venta();
                sumatoriaVenta.CantCigarrillos = 0;
                sumatoriaVenta.PrecioTotal = 0;
                sumatoriaVenta.PrecioTotalCigarrillo = 0;
                foreach (Venta v in ventasHoy)
                {
                    sumatoriaVenta.CantCigarrillos += v.CantCigarrillos;
                    sumatoriaVenta.PrecioTotal += v.PrecioTotal;
                    sumatoriaVenta.PrecioTotalCigarrillo += v.PrecioTotalCigarrillo;
                }
                return sumatoriaVenta;
            }
        }
        public Venta getVentasMes()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var ventas = db.GetCollection<Venta>("ventas");
                List<Venta> ventasHoy = ventas.Find(x => x.Fecha.Date.Month == DateTime.Now.Date.Month && x.esVentaPropia).ToList();

                Venta sumatoriaVenta = new Venta();
                sumatoriaVenta.CantCigarrillos = 0;
                sumatoriaVenta.PrecioTotal = 0;
                sumatoriaVenta.PrecioTotalCigarrillo = 0;
                foreach (Venta v in ventasHoy)
                {
                    sumatoriaVenta.CantCigarrillos += v.CantCigarrillos;
                    sumatoriaVenta.PrecioTotal += v.PrecioTotal;
                    sumatoriaVenta.PrecioTotalCigarrillo += v.PrecioTotalCigarrillo;
                }
                return sumatoriaVenta;
            }
        }
        public double calcularGananciaCigarrillo() {
            Preferencia preferencia_aux;
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                preferencia_aux = preferencias.Query().ToList().First();
            }
            return CantCigarrillos * preferencia_aux.GananciaCigarrillo;
        }
        public double calcularGananciaMercaderia() {
            Preferencia preferencia_aux;
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                var preferencias = db.GetCollection<Preferencia>("preferencias");
                preferencia_aux = preferencias.Query().ToList().First();
            }
            return PrecioTotal *(preferencia_aux.Ganancia/100);
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
                   
                    if (orden.cantProducto != 0)
                    {
                        PrecioTotal += (orden.precio * orden.cantProducto);
                    }
                    else {
                        PrecioTotal += orden.precio;
                    }
                }
            }
        }
    }
}
