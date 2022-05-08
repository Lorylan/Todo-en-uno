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
using LiteDB;
using Todo_en_uno.Helpers;

namespace Todo_en_uno.Forms
{
    public partial class Fiado : Form
    {
        public Fiado()
        {
            InitializeComponent();
        }

        private void Fiado_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            dataGridView1.DataSource = Nota.GetNotas();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["Texto"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Nota.GetNotasConNombre(TxtNombre.Text);
        }

        private int? TomarId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch(Exception e)
            {
                return null;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int? id = TomarId();
            if (id != null)
            {
                var result = new Borrado("¿Estas seguro que queres borrar esta nota?").ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
                    {
                        db.GetCollection<Nota>("notas").Delete(id);
                    }
                }
            }
            TxtTexto.Text = "";
            Refrescar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            NuevaNota notasForm = new NuevaNota();
            notasForm.ShowDialog();

            Refrescar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            cargarNota(id);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int? id = TomarId();
            if (id != null)
            {
                Nota.EditarNota((int)id, TxtTexto.Text);
                Refrescar();
            }
        }

        private void cargarNota(int id)
        {
            Nota n = Nota.GetNotaConId(id);
            TxtTexto.Text = n.Texto;
        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            int? id = TomarId();
            if(id != null) cargarNota((int)id);
        }

        
    }
}
