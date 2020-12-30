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
namespace Todo_en_uno.Forms
{
    public partial class EliminarVenta : Form
    {
        Venta venta = new Venta();
        public EliminarVenta()
        {
            InitializeComponent();
            this.Text = "Eliminar venta";
            refrescar();
        }

        private void txt_fecha_ValueChanged(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar() {
            datos_venta.DataSource = venta.getVentaDe(false, txt_fecha.Value.Date);
            datos_venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datos_venta.Columns[0].Visible = false;
            datos_venta.Columns[1].HeaderText = "Precio total";
            datos_venta.Columns[2].HeaderText = "Precio total cigarrillos";
            datos_venta.Columns[3].HeaderText = "Cant. cigarrillos";
            datos_venta.Columns[4].Visible = false;
        }
        private void btn_mod_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(datos_venta.Rows[datos_venta.CurrentRow.Index].Cells[0].Value.ToString());
                var result = new Borrado("¿Estas seguro que queres borrar esta venta?").ShowDialog();
                if (result == DialogResult.OK)
                {
                    venta.eliminarVenta((int)i);
                }
                refrescar();
            }
            catch { }
        }

        
    }
}
