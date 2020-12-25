using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo_en_uno.Forms;

namespace Todo_en_uno
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Fiado());
=======
            Application.Run(new FormVenta(false));
>>>>>>> 868c72c60bffb62c1686ba06e848ee0d490d1658
        }
    }
}
