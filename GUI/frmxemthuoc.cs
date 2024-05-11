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
    public partial class frmxemthuoc : Form
    { xemthuocBUS xemthuoc =new xemthuocBUS();

        public frmxemthuoc()
        {
            InitializeComponent();
        }
        private void load_data()
        {        dgvdsthuoc.AllowUserToResizeColumns = true;
            dgvdsthuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            xemthuocBUS xem = new xemthuocBUS();
            dgvdsthuoc.DataSource = xem.Laydanhsachthuoc();
        }
        private void xemtatcathuoc_Click(object sender, EventArgs e)
        {
            load_data();

        }

        private void btnxemang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmaloai.Text))
            {
                dgvdsthuoc.DataSource = xemthuoc.timmathuoc(txtmaloai.Text);
            }
            else
            {
                MessageBox.Show("Chưa nhập Mã Thuốc !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
