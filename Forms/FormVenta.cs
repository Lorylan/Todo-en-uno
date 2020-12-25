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
using LiteDB;

namespace Todo_en_uno.Forms
{
    public partial class FormVenta : Form
    {
        bool primeraOrden = true;
        Orden orden;
        Venta venta;
        bool esVentaPropia;
        private void vaciarTxtArriba() {
            txt_codigo.Text = "";
            txt_cant.Text = "1";
            txt_precio.Text = "";
        }
        private void actualizarTablaPrecio() {
            venta.calcularPrecio();
            txt_total.Text = "$" + (venta.PrecioTotal + venta.PrecioTotalCigarrillo).ToString(); ;
            txt_total_credito.Text = "$" + venta.calcularCredito(esVentaPropia).ToString();
            txt_total_debito.Text = "$" + venta.calcularDebito(esVentaPropia).ToString();
            datos_venta.DataSource = orden.getAll(esVentaPropia);
            
        }
        public void agregarBotones() {
            DataGridViewButtonColumn colMas = new DataGridViewButtonColumn()
            {
                HeaderText = "",
                Text = "+",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn colMenos = new DataGridViewButtonColumn()
            {
                HeaderText = "",
                Text = "-",
                UseColumnTextForButtonValue = true,

            };
            datos_venta.Columns.Insert(5, colMenos);
            datos_venta.Columns.Insert(7, colMas);
        }
        //.......................................................................//

        public FormVenta(bool ventaPropia)
        {
            InitializeComponent();
            esVentaPropia = ventaPropia;
            orden = new Orden();
            venta = new Venta();
            btn_eliminar.Enabled = false;
            if (orden.getAll(esVentaPropia).Count != 0)
            {
                actualizarTablaPrecio();
                agregarBotones();
                primeraOrden = false;
            }
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                int cant = Convert.ToInt32(txt_cant.Text);
                if (cant > 0) {
                    if (txt_precio.Text.Trim().Equals(""))
                    {
                        if (!orden.cargarOrden(txt_codigo.Text, cant, esVentaPropia)) {
                            MessageBox.Show("EL codigo del producto no es valido");
                        };
                    }
                    else
                    {
                        try
                        {
                            double precio = Convert.ToDouble(txt_precio.Text);
                            if (!orden.cargarOrdenConPrecio(precio, txt_codigo.Text, esVentaPropia)) {
                                MessageBox.Show("EL codigo del producto no es valido");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Ingrese un precio valido");
                            vaciarTxtArriba();
                        }

                    }
                    actualizarTablaPrecio();
                    vaciarTxtArriba();
                    if (primeraOrden)
                    {
                        primeraOrden = false;
                        agregarBotones();
                    }
                }
                else{
                    MessageBox.Show("La cantidad debe ser mayor que 0");
                    vaciarTxtArriba();
                }
                
            }
            catch {
                MessageBox.Show("Ingrese un número valido en cantidad");
                vaciarTxtArriba();
            }
            
            

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
            if (orden.getAll(esVentaPropia).Count != 0)
            {

                venta.cargarVenta();
                venta.actualizarStock();
                orden.eliminarOrden();
                actualizarTablaPrecio();
                orden = new Orden();
                venta = new Venta();
                int cant = venta.getAll().Count;
                MessageBox.Show("Su venta fue creada con exito, lleva "+cant);
            }
            else {
                MessageBox.Show("La venta no posee ningun producto");
            }
            
        }

        private void datos_venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                var datos = datos_venta.Rows[i];
                var cant = Convert.ToInt32(datos.Cells["cantProducto"].Value.ToString());
                int id = Convert.ToInt32(datos.Cells["Id"].Value.ToString());
                string codigo = orden.FindId(id).codigo.ToString();
                if ((e.ColumnIndex == 0) && (cant > 1))
                {
                    cant--;
                }
                if (e.ColumnIndex == 1)
                {
                    cant++;
                }
                orden.actualualizar(id, cant);
                actualizarTablaPrecio();
            }
            catch { 
                
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int i = datos_venta.CurrentRow.Index;
            int id = Convert.ToInt32(datos_venta.Rows[i].Cells["Id"].Value.ToString());
            var result = MessageBox.Show("¿Estas seguro que queres borrar esta orden?", "Borrar Orden", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orden.elimanar(id);
                datos_venta.DataSource = orden.getAll(esVentaPropia);
                btn_eliminar.Enabled = false;
                actualizarTablaPrecio();
            }
            
        }

        private void datos_venta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_eliminar.Enabled = true;
        }
    }
}
