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
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            dataGridView1.DataSource = Producto.GetProductos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProd = new AgregarProducto();
            agregarProd.ShowDialog();

            Refrescar();
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
                var result = MessageBox.Show("¿Estas seguro que queres borrar este producto?", "Borrar Producto", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    using(var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
                    {
                        db.GetCollection<Producto>("productos").Delete(id);
                    }
                }
            }
            Refrescar();
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

        private void btn_sim_Click(object sender, EventArgs e)
        {
            Simulacro sim = new Simulacro();
            sim.ShowDialog();
        }
    }
}
