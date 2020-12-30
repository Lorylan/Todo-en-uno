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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            Refrescar();
        }

        
        

        private void Refrescar()
        {
            dataGridView1.DataSource = Producto.GetProductos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Precio base";
            dataGridView1.Columns[3].HeaderText = "Precio venta";
            dataGridView1.Columns[4].HeaderText = "Stock actual";
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].HeaderText = "Stock minimo";
            dataGridView1.Columns[5].Width = 25;
            dataGridView1.Columns[7].HeaderText = "Es cigarrillo";
            dataGridView1.Columns[7].Width = 25;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProd = new AgregarProducto();
            agregarProd.ShowDialog();

            Refrescar();
            BtnFiltrar_Click(sender, e);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? id = TomarId();
            if(id != null)
            {
                AgregarProducto agregarProd = new AgregarProducto(id);
                agregarProd.ShowDialog();
            }
            Refrescar();
            BtnFiltrar_Click(sender, e);
        }

        private int? TomarId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = TomarId();
            if (id != null)
            {
                var result = new Borrado("¿Estas seguro que queres borrar este producto?").ShowDialog();
                if(result == DialogResult.OK)
                {
                    Producto.DeleteProducto((int)id);
                }
            }
            Refrescar();
            BtnFiltrar_Click(sender, e);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Producto.GetProductosFiltrados(TxtNombre.Text, TxtCodigo.Text, CheckStock.Checked);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtCodigo.Text = "";
            CheckStock.Checked = false;
            Filtrar(sender, e);
        }
        
    }
}
