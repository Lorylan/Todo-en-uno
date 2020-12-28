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
    public partial class Simulacro : Form
    {
        public List<Producto_Sim> items = new List<Producto_Sim>();
        public BindingSource b = new BindingSource();
        public double costoFinal = 0;
        public Simulacro()
        {
            InitializeComponent();
            
        }

        private void Simulacro_Load(object sender, EventArgs e)
        {
            var prods = Producto.GetProductosFiltrados("", "", true);
            List<Producto_Sim> resul = new List<Producto_Sim>();
            foreach(Producto p in prods)
            {
                var stock = p.StockMinimo - p.StockActual;
                costoFinal += stock * p.PrecioBase;
                resul.Add(
                    new Producto_Sim(
                        p.Id,
                        p.Nombre,
                        p.PrecioBase,
                        stock
                        ));
            }
            items = resul;
            b.DataSource = resul;
            dataGridView1.DataSource = b;
            labelCosto.Text += String.Format("{0:0.##}", costoFinal);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString());
            Producto_Sim p = items.Find(x => x.Id == id);
            double viejoCosto = p.StockFaltante * p.PrecioBase;
            try
            {
                p.StockFaltante = int.Parse(TxtCant.Text);
                double nuevoCosto = double.Parse(String.Format("{0:0.##}", p.StockFaltante * p.PrecioBase));
                p.Costo = nuevoCosto;
                double cambio = nuevoCosto - viejoCosto;
                costoFinal += cambio;
                labelCosto.Text = "$ " + String.Format("{0:0.##}", costoFinal);
                b.ResetBindings(true);
            }
            catch
            {
                MessageBox.Show("Ingrese un numero valido en cantidad");
            }        
        }
    }
}
