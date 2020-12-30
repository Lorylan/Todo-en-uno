using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo_en_uno.Forms;
using Todo_en_uno.Clases;

namespace Todo_en_uno
{
    public partial class Home : Form
    {
        Preferencia preferencia;
        public Home()
        {
            InitializeComponent();
            preferencia = new Preferencia();
            if (!preferencia.existePteferencia()) {
                FormConfiguracion fc = new FormConfiguracion();
                fc.ShowDialog();
            }

        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            FormVenta f = new FormVenta(false);
            f.ShowDialog();
        }

        private void btn_venta_propia_Click(object sender, EventArgs e)
        {
            FormVenta f = new FormVenta(true);
            f.ShowDialog();
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            i.ShowDialog();
        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            Fiado f = new Fiado();
            f.ShowDialog();
        }

        private void btn_ganancias_Click(object sender, EventArgs e)
        {
            FormConfiguracion fc = new FormConfiguracion();
            fc.ShowDialog();
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            Simulacro sim = new Simulacro();
            sim.ShowDialog();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.ShowDialog();
        }
    }
}
