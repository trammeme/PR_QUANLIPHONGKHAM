using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           //  Application.SetCompatibleTextRenderingDefault(false);
        //  Application.Run(new frmtaobenhan ());
           //  Application.Run(new frmQLBN ());
            //    Application.Run(new frmDKLK());
           //  Application.Run(new frmCaTruc());
            Application.Run(new frmLogin());

            //  Application.Run(new frmQLNV());
            //   Application.Run(new frmxemthuoc());
            // Application.Run(new frm());


        }
    }
}
