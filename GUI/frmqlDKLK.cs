using DevExpress.XtraPrinting.BarCode;
using DOANPK.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmqlDKLK : Form
    {            qllkBUS dkk = new qllkBUS();

        public frmqlDKLK()
        {
            InitializeComponent();
        }
      

            private void load_data()
            {
                qllkBUS xdklk = new qllkBUS();
                dgvdklk.DataSource = xdklk.LayDSlk();
            }



           
        

        private void btnxemlich_Click_1(object sender, EventArgs e)
        {
                load_data();

        }
    }
    }
