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
    public partial class frmQLBN : Form
    {
        QLBNBUS bnBUS = new QLBNBUS();

        public frmQLBN()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            QLBNBUS bnBUS = new QLBNBUS();
            dgvQLBN.DataSource = bnBUS.LayDSBenhNhan();
        }
       
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaBN.Text))
            {
                if (bnBUS.UpdateBenhNhan(txtMaBN.Text, txtTenBN.Text, dtpNgaysinh.Value, txtDC.Text, txtSDT.Text, MaBNcu))
                {

                    load_data();
                    txtMaBN.Clear();
                    txtTenBN.Clear();

                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            MessageBox.Show("Không sửa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        String MaBNcu;

        private void dgvQLBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvQLBN.Rows[e.RowIndex];
                txtMaBN.Text = row.Cells["MaBN"].Value.ToString();
                MaBNcu = txtMaBN.Text;
                txtTenBN.Text = row.Cells["TenBN"].Value.ToString();
                dtpNgaysinh.Value = DateTime.Parse(row.Cells["Ngaysinh"].Value.ToString());
                txtDC.Text = row.Cells["DC"].Value.ToString();
                txtSDT.Text = row.Cells["Sdt"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bnBUS.DeleteBenhNhan(txtMaBN.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtMaBN.Clear();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaBN.Text) && !string.IsNullOrEmpty(txtTenBN.Text))
            {


                if (bnBUS.JKBN(txtMaBN.Text, txtTenBN.Text, dtpNgaysinh.Value, txtDC.Text, txtSDT.Text))
                {
                    load_data();
                    txtMaBN.Clear();
                    txtTenBN.Clear();


                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
            

        }

        private void frmQLBN_Load(object sender, EventArgs e)
        {
            dgvQLBN.AllowUserToResizeColumns = true;
            dgvQLBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmchucnang frmchucnang = new frmchucnang();
            frmchucnang.Hide();
            // Mở form đăng nhập
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
    }

