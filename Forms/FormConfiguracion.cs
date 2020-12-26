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
    public partial class FormConfiguracion : Form
    {
        Preferencia preferencia;
        public FormConfiguracion()
        {
            InitializeComponent();
            preferencia = new Preferencia();
            if (!preferencia.existePteferencia())
            {
                txt_credito.Text ="0";
                txt_cigarrillo.Text = "0";
                txt_debito.Text = "0";
                txt_mercaderia.Text = "0";
            }
            else {
                preferencia = preferencia.getPreferencia();
                txt_mercaderia.Text = preferencia.Ganancia.ToString();
                txt_debito.Text = preferencia.GananciaDebito.ToString();
                txt_cigarrillo.Text = preferencia.GananciaCigarrillo.ToString();
                txt_credito.Text = preferencia.GananciaCredito.ToString();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int mercaderia = Convert.ToInt32(txt_mercaderia.Text);
                try
                {
                    double debito = Convert.ToDouble(txt_debito.Text);
                    try
                    {
                        double credito = Convert.ToDouble(txt_credito.Text);
                        try
                        {
                            double cigarrillo = Convert.ToDouble(txt_cigarrillo.Text);
                            var preferecia_aux = new Preferencia {
                                Ganancia = mercaderia,
                                GananciaCigarrillo = cigarrillo,
                                GananciaCredito = credito,
                                GananciaDebito = debito

                            };
                            preferencia.Editar(preferecia_aux);
                        }
                        catch
                        {
                            MessageBox.Show("Ingrese en cigrrillo un valor válido");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese en credito un valor válido");
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese en debito un valor válido");
                }
            }
            catch {
                MessageBox.Show("Ingrese en mercaderia un valor válido");
            }
        }
    }
}
