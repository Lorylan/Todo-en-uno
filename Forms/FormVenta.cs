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
using Todo_en_uno;
using Todo_en_uno.Helpers;

namespace Todo_en_uno.Forms
{
    public partial class FormVenta : Form
    {
        Orden orden;
        Venta venta;
        
        private void vaciarTxtArriba() {
            txt_codigo.Text = "";
            txt_cant.Text = "1";
            txt_precio.Text = "";
        }
        private void actualizarTablaPrecio() {
            txt_total.Text = "$" + venta.PrecioTotal.ToString();
            txt_total_credito.Text = "$" + venta.calcularCredito().ToString();
            txt_total_debito.Text = "$" + venta.calcularDebito().ToString();
            datos_venta.DataSource = orden.getAll();
        }
        //.......................................................................//

        public FormVenta()
        {
            InitializeComponent();
            orden = new Orden();
            venta = new Venta();
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            if (orden.getAll().Count != 0) {
                actualizarTablaPrecio();
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            vaciarTxtArriba();
            if (txt_precio.Text.Trim().Equals("")) {
                orden.cargarOrden(null ,txt_codigo.Text, Convert.ToInt32(txt_cant.Text), false);
            }
            orden.cargarOrden(Convert.ToDouble(txt_precio.Text), txt_codigo.Text, Convert.ToInt32(txt_cant.Text), false);
            venta.calcularPrecio();
            actualizarTablaPrecio();
   
        }
        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (!txt_codigo.Text.Equals(""))
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void btn_nueva_venta_Click(object sender, EventArgs e)
        {
            if (orden.getAll().Count != 0)
            {
                orden.eliminarOrden();
                venta.cargarVenta();
                orden = new Orden();
                venta = new Venta();
            }
            else {
                MessageBox.Show("La venta no posee ningun producto");
            }
            
        }

        private void Selecciona(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
