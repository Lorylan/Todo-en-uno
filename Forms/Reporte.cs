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

        public Reporte()
        {
            InitializeComponent();
            venta = new Venta();
            
            this.Text = "Reporte";

        }

        

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txt_desde.Value > txt_hasta.Value)
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor que la fecha'Hasta'");
            }
            else {
                Venta sumatoriaVentaPropia;
                Venta sumatoriaVenta;
                sumatoriaVentaPropia = venta.getVentas(true, txt_desde.Value.Date, txt_hasta.Value.Date);
                sumatoriaVenta = venta.getVentas(false, txt_desde.Value.Date, txt_hasta.Value.Date);
                txt_venta_c.Text = sumatoriaVenta.PrecioTotalCigarrillo.ToString();
                txt_venta_m.Text = sumatoriaVenta.PrecioTotal.ToString();
                txt_ganancia_c.Text = sumatoriaVenta.calcularGananciaCigarrillo().ToString();
                txt_ganancia_m.Text = sumatoriaVenta.calcularGananciaMercaderia().ToString();
                txt_pago_m.Text = sumatoriaVentaPropia.PrecioTotal.ToString();
                txt_pago_c.Text = sumatoriaVentaPropia.PrecioTotalCigarrillo.ToString();
                txt_reponer_c.Text = (Convert.ToDouble(txt_venta_c.Text) - Convert.ToDouble(txt_ganancia_c.Text)).ToString();
            }
            
        }
    }
}
