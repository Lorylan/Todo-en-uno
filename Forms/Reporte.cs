using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo_en_uno.Clases;
using Todo_en_uno.Helpers;

namespace Todo_en_uno.Forms
{
    public partial class Reporte : Form
    {
        Venta venta;
        public Reporte(bool deHoy)
        {
            InitializeComponent();
            venta = new Venta();
            Venta sumatoriaVentaPropia;
            Venta sumatoriaVenta;
            datos_ventas.DataSource = venta.getAll();
            if (deHoy)
            {
                sumatoriaVentaPropia = venta.getVentasHoy(true);
                sumatoriaVenta = venta.getVentasHoy(false);
            }
            else {
                sumatoriaVentaPropia = venta.getVentasMes(true);
                sumatoriaVenta = venta.getVentasMes(false);
            }
            txt_ganancia_c.Text= sumatoriaVenta.PrecioTotalCigarrillo.ToString();
            txt_ganancia_m.Text = sumatoriaVenta.PrecioTotal.ToString();
            txt_venta_c.Text = sumatoriaVenta.calcularGananciaCigarrillo().ToString();
            txt_venta_m.Text= sumatoriaVenta.calcularGananciaMercaderia().ToString() ;
            txt_pago_m.Text = sumatoriaVentaPropia.PrecioTotal.ToString();
            txt_pago_c.Text = sumatoriaVentaPropia.PrecioTotalCigarrillo.ToString();
            txt_reponer_c.Text = (Convert.ToDouble(txt_venta_c.Text) - Convert.ToDouble(txt_ganancia_c.Text)).ToString();
        }
    }
}
