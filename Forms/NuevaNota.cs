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
using Todo_en_uno.Clases;
using Todo_en_uno.Helpers;

namespace Todo_en_uno.Forms
{
    public partial class NuevaNota : Form
    {
        public NuevaNota()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string nota = TxtNota.Text;
            if(nombre.Trim().Equals("") || nota.Trim().Equals(""))
            {
                MessageBox.Show("Falta completar un campo");
            }
            else
            {
                using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
                {
                    var notas = db.GetCollection<Nota>("notas");
                    Nota n = notas.Find(x => x.Nombre.ToLower().Equals(nombre.ToLower())).FirstOrDefault();
                    if(n != null)
                    {
                        MessageBox.Show("Ya existe una nota con ese nombre.");
                    }
                    else
                    {
                        notas.Insert(new Nota(nombre, nota));
                        Close();
                    }
                }
            }
        }
    }
}
