﻿using System;
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
        List<Producto> productosFiltro;
        Producto producto;
        private void vaciarTxtArriba() {
            txt_codigo.Text = "";
            txt_cant.Text = "1";
           txt_precio.Text = "";
            txt_nombre.Text = "";
            txt_pago_cliente.Text = "";
            txt_vuelto.Text = "$";

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
            datos_venta.RowHeadersVisible = false;
            datos_venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datos_venta.Columns[0].Visible = false;
            datos_venta.Columns[1].HeaderText = "Codigo";
            datos_venta.Columns[2].HeaderText = "Nombre";
            datos_venta.Columns[3].HeaderText = "Es cigarrillo";
            datos_venta.Columns[3].Width = 50;
            datos_venta.Columns[4].HeaderText = "Precio";
            datos_venta.Columns[5].Width = 25;
            datos_venta.Columns[6].HeaderText = "Cant.";
            datos_venta.Columns[6].Width = 50;
            datos_venta.Columns[7].Width = 25;
            datos_venta.Columns[8].Visible = false;
            

        }
        //.......................................................................//

        public FormVenta(bool ventaPropia)
        {
            InitializeComponent();
            esVentaPropia = ventaPropia;
            orden = new Orden();
            venta = new Venta();
            productosFiltro = new List<Producto>();
            producto = new Producto();
            
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

                venta.cargarVenta(esVentaPropia);
                venta.actualizarStock();
                orden.eliminarOrden();
                actualizarTablaPrecio();
                orden = new Orden();
                venta = new Venta();
                int cant = venta.getAll().Count;
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
            if (btn_eliminar.BackColor != Color.DimGray) {
                int i = datos_venta.CurrentRow.Index;
                int id = Convert.ToInt32(datos_venta.Rows[i].Cells["Id"].Value.ToString());
                var result = new Borrado("¿Estas seguro que queres borrar esta orden?").ShowDialog();
                if (result == DialogResult.OK)
                {
                    orden.elimanar(id);
                    datos_venta.DataSource = orden.getAll(esVentaPropia);
                    btn_eliminar.BackColor = Color.DimGray;
                    actualizarTablaPrecio();

                }
            }
            
        }

        private void datos_venta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_eliminar.BackColor = Color.FromArgb(36, 24, 52);

        }

        private void txt_pago_cliente_TextChanged(object sender, EventArgs e)
        {
            if (!txt_pago_cliente.Text.Equals(""))
            {
                try
                {
                    double pago_c = Convert.ToDouble(txt_pago_cliente.Text);
                    double total = Convert.ToDouble(txt_total.Text.Replace("$", ""));
                    txt_vuelto.Text = "$" + (pago_c - total);
                }
                catch {
                    MessageBox.Show("Ingrese un número válido para el pago de cliente");
                    txt_pago_cliente.Text = "";
                }
            }
            else {
                txt_vuelto.Text = "$";
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            new EliminarVenta().ShowDialog();
            
        }
        private void txt_nombre_f_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto elegido = productosFiltro.Find(x => x.Nombre == txt_nombre_f.SelectedItem.ToString());
            txt_codigo.Text = elegido.Codigo.ToString();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (!txt_nombre.Text.Trim().Equals(""))
            {
                productosFiltro.Clear();
                txt_nombre_f.Items.Clear();
                productosFiltro = producto.GetProductosFiltradosNombre(txt_nombre.Text);
                foreach (Producto aux in productosFiltro)
                {
                    txt_nombre_f.Items.Add(aux.Nombre);
                }
            }
            else
            {
                txt_nombre_f.Items.Clear();
            }
        }
    }
}
