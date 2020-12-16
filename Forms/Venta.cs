using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_en_uno.Forms
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = txt_codigo.Text;
            txt_codigo.Text = "";
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (!txt_codigo.Text.Equals(""))
            {
                timer1.Stop();
                timer1.Start();
            }
            
        }
    }
}
