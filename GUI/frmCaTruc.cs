using DOANPK.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCaTruc : Form
    {
        CaTrucBUS ctBUS = new CaTrucBUS();

        public frmCaTruc()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            CaTrucBUS ctBUS = new CaTrucBUS();
            dgvCT.DataSource = ctBUS.LayDSCaTruc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           load_data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaCT.Text) && !string.IsNullOrEmpty(txtTenCT.Text))
            {


                if (ctBUS.JKCT(txtMaCT.Text, txtTenCT.Text, dtpNgaytruc.Value))
                {
                    load_data();
                    txtTenCT.Clear();
                    txtMaCT.Clear();


                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private bool ValidateInput()
        {
            throw new NotImplementedException();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ctBUS.DeleteCaTruc(txtMaCT.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtMaCT.Clear();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaCT.Text))
            {
                if (ctBUS.UpdateCaTruc(txtMaCT.Text, txtTenCT.Text, MaCTcu))
                {

                    load_data();
                    txtMaCT.Clear();
                    txtTenCT.Clear();

                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            MessageBox.Show("Không sửa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        String MaCTcu;

        private void dgvCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvCT.Rows[e.RowIndex];
                txtMaCT.Text = row.Cells["MaCT"].Value.ToString();
                MaCTcu = txtMaCT.Text;
                txtTenCT.Text = row.Cells["TenCT"].Value.ToString();
            }
        }

        private void frmCaTruc_Load(object sender, EventArgs e)
        {

        }
    }
}
