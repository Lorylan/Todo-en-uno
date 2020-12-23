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
        public Simulacro()
        {
            InitializeComponent();
        }

        private void Simulacro_Load(object sender, EventArgs e)
        {
            var prods = Producto.GetProductosFiltrados("", "", true);
            List<Producto_Sim> resul = new List<Producto_Sim>();
            double costoFinal = 0;
            foreach(Producto p in prods)
            {
                var stock = p.StockMinimo - p.StockActual;
                costoFinal += stock * p.PrecioBase;
                resul.Add(
                    new Producto_Sim(
                        p.Nombre,
                        p.PrecioBase,
                        stock
                        ));
            }
            dataGridView1.DataSource = resul;
            labelCosto.Text += String.Format("{0:0.##}", costoFinal);        
        }
    }
}
