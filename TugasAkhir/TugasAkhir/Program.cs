using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormHome());
           // Application.Run(new FormHome2());
            Application.Run(new Form1());
            //Application.Run(new FormPetugas());
            //Application.Run(new FormTabelMahasiswa());
            //Application.Run(new FormTabelBuku());
           // Application.Run(new FormFilter());
        }
    }
}
