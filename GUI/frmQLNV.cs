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
    public partial class frmQLNV : Form
    {        QLNVBUS NVBUS = new QLNVBUS();

        public frmQLNV()
        {
            InitializeComponent();
        }

        


        private void load_data()
        {
            QLNVBUS HH = new QLNVBUS();
            dgvdsnv.DataSource = HH.LayDSNV();
        }



        private void btnxemdsnv_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (NVBUS.Deletenv(txtmanv.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtmanv.Clear();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtmanv.Text))
            {

                if (!string.IsNullOrEmpty(txttennv.Text) && (!string.IsNullOrEmpty(txtgioitinh.Text) && (!string.IsNullOrEmpty(txtsdt.Text) && (!string.IsNullOrEmpty(txtmack.Text)))))
                {

                    {

                        {
                            if (NVBUS.CtTennv(txtmanv.Text, txttennv.Text)&& NVBUS.CtGioitinh(txtmanv.Text, txtgioitinh.Text) && NVBUS.Ctsdtnv(txtmanv.Text, txtmanv.Text) && NVBUS.Ctcknv(txtmanv.Text, txtmack.Text))
                            {
                                load_data();
                                txtmanv.Clear();
                                txttennv.Clear();
                                txtgioitinh.Clear();
                                txtsdt.Clear();
                                txtmack.Clear();

                                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           
                if (!string.IsNullOrEmpty(txtmanv.Text))
                {
                    DateTime nsnv = ngaysinhnv.Value;

                    if (NVBUS.themnv(txtmanv.Text, txttennv.Text, txtgioitinh.Text, txtsdt.Text, nsnv, txtmack.Text, txtmaloai.Text))


                    {
                        load_data();
                        txtmanv.Clear();
                        txttennv.Clear();
                        txtgioitinh.Clear();
                        txtsdt.Clear();
                        txtmack.Clear();
                    txtmaloai.Clear();



                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                {
                    MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }

        private void dgvdsnv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvdsnv.Rows[e.RowIndex];
                txtmanv.Text = row.Cells["MaNV"].Value.ToString();
                txttennv.Text = row.Cells["Hoten"].Value.ToString();
                txtgioitinh.Text = row.Cells["Gioitinh"].Value.ToString();
                txtsdt.Text = row.Cells["Sdt"].Value.ToString();
                txtmaloai.Text = row.Cells["Maloainv"].Value.ToString();
                txtmack.Text = row.Cells["MaCK"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            dgvdsnv.AllowUserToResizeColumns = true;
            dgvdsnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mở form đăng nhập
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
    }
