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
    {            XembenhnhaBUS dkk = new XembenhnhaBUS();

        public frmqlDKLK()
        {
            InitializeComponent();
        }
      

            private void load_data()
            {
                XembenhnhaBUS xdklk = new XembenhnhaBUS();
                dgvdklk.DataSource = xdklk.LayDSBN();
            }



           
        private void btnxemlich_Click(object sender, EventArgs e)
        {
                load_data();

        }
    }
    }
