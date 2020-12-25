using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using Todo_en_uno.Helpers;
using Todo_en_uno.Clases;

namespace Todo_en_uno.Forms
{
    public partial class AgregarProducto : Form
    {
        public int? id;
        public AgregarProducto(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
                cargarDatos();
                this.Text = "Editar Producto";
                button1.Text = "Editar Producto";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validarInput())
            {
                using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
                {
                    Producto p;
                    if (id == null)
                    {
                        p = new Producto();
                    }
                    else
                    {
                        p = db.GetCollection<Producto>("productos").FindById(id);
                    }
                    p.Nombre = TxtNombre.Text;
                    p.Codigo = TxtCodigo.Text;
                    if(!(TxtPCaja.Text.Trim().Equals("") && TxtUnidades.Text.Trim().Equals("")))
                    {
                       p.PrecioBase = Math.Round(double.Parse(TxtPCaja.Text) / double.Parse(TxtUnidades.Text), 2, MidpointRounding.AwayFromZero);
                    }    
                    p.PrecioVenta = double.Parse(TxtPVenta.Text);
                    p.StockActual = int.Parse(TxtStock.Text);
                    p.StockMinimo = int.Parse(TxtStockMin.Text);
                    p.EsCigarrillo = CheckCigarrillo.Checked;
                    if(id == null)
                    {
                        db.GetCollection<Producto>("productos").Insert(p);
                    }
                    else
                    {
                        db.GetCollection<Producto>("productos").Update(p);
                    }
                    Close();
                }
            }    
        }

        private void cargarDatos()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                Producto p = db.GetCollection<Producto>("productos").FindById(id);
                TxtNombre.Text = p.Nombre;
                TxtCodigo.Text = p.Codigo;
                TxtPVenta.Text = p.PrecioVenta.ToString();
                TxtStock.Text = p.StockActual.ToString();
                TxtStockMin.Text = p.StockMinimo.ToString();
                LabelPrecioUnidad.Text = p.PrecioBase.ToString();
                CheckCigarrillo.Checked = p.EsCigarrillo;
            }
        }

        private bool validarInput()
        {
            if(TxtNombre.Text.Trim().Equals("") || 
                TxtPVenta.Text.Trim().Equals("") || 
                TxtStock.Text.Trim().Equals("") || 
                TxtStockMin.Text.Trim().Equals("") ||
                LabelPrecioUnidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return false;
            }

            if(!TxtPCaja.Text.Trim().Equals(""))
            {
                try
                {
                    double precioCaja = double.Parse(TxtPCaja.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("El Precio de Caja debe ser un numero");
                    return false;
                }
            }
            
            if(!TxtUnidades.Text.Trim().Equals(""))
            {
                try
                {
                    double unidades = int.Parse(TxtUnidades.Text);
                    if (unidades <= 0)
                    {
                        MessageBox.Show("Las unidades deben tener un valor igual o mayor a 1");
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("La cantidad de unidades debe ser un numero");
                    return false;
                }
            }          

            try
            {
                double venta = double.Parse(TxtPVenta.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("El precio de venta debe ser un numero");
                return false;
            }

            try
            {
                double stock = int.Parse(TxtStock.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("El Stock Inicial debe ser un numero");
                return false;
            }

            try
            {
                double stockmin = int.Parse(TxtStockMin.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("El Stock Minimo debe ser un numero");
                return false;
            }

            return true;
        }

        private void TxtPCaja_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LabelPrecioUnidad.Text = String.Format("{0:0.##}", double.Parse(TxtPCaja.Text) / double.Parse(TxtUnidades.Text));
            }
            catch{}
        }
    }
}
