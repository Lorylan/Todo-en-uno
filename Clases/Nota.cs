using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Todo_en_uno.Helpers;

namespace Todo_en_uno.Clases
{
    public class Nota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Texto { get; set; }

        public Nota(string nombre, string texto)
        {
            this.Nombre = nombre;
            this.Texto = texto;
        }

        public static List<Nota> GetNotas()
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                return db.GetCollection<Nota>("notas").Query().ToList();
            }
        }

        public static List<Nota> GetNotasConNombre(string n)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                return db.GetCollection<Nota>("notas").Query().Where(x => x.Nombre.Contains(n)).ToList();
            }
        }

        public static Nota GetNotaConId(int id)
        {
            using (var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                return db.GetCollection<Nota>("notas").FindById(id);
            }
        }

        public static void EditarNota(int id, string texto)
        {
            using(var db = new LiteDatabase(Configuracion.rutaBaseDeDatos))
            {
                Nota n = db.GetCollection<Nota>("notas").FindById(id);
                n.Texto = texto;
                db.GetCollection<Nota>("notas").Update(n);
            }
        }
    }

    
}
