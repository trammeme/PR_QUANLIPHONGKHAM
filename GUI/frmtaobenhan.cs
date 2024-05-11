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
    public partial class frmtaobenhan : Form
    {            TaoBABUS benhan = new TaoBABUS();
        XembenhnhaBUS dkk = new XembenhnhaBUS();

        public frmtaobenhan()
        {
            InitializeComponent();
        }
        
            private void load_data()
            {
                TaoBABUS benhanh = new TaoBABUS();
                dgvdsbenhan.DataSource = benhanh.Laydanhsachbenhan();
            }


        

        private void load_data2()
        {
            XembenhnhaBUS xdklk = new XembenhnhaBUS();
            dgvdsbenhan.DataSource = xdklk.LayDSBN();
        }




        private void btnxemlich_Click(object sender, EventArgs e)
        {
            load_data();

        }
        private void btnxemtatcaba_Click(object sender, EventArgs e)
        {
              load_data  ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String chonbs = cbbbacsi.SelectedItem?.ToString(); // Sử dụng SelectedItem

            if (!string.IsNullOrEmpty(txtmaba.Text))
            {

                if (benhan.themba(txtmaba.Text, chonbs, txtchuadoan.Text, txtmabn.Text))


                {
                    load_data();
                    txtmaba.Clear();
                    txtchuadoan.Clear();
                    txtmabn.Clear();
                   


                    MessageBox.Show("Tạo bệnh án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            {
                MessageBox.Show("Không thể tạo bệnh án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void dgvdsbenhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvdsbenhan.Rows[e.RowIndex];
                txtmaba.Text = row.Cells["MaBA"].Value.ToString();
                txtchuadoan.Text = row.Cells["Chuandoan"].Value.ToString();
                txtmabn.Text = row.Cells["MaBN"].Value.ToString();
               
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmtaobenhan_Load(object sender, EventArgs e)
        {
            dgvdsbenhan.AllowUserToResizeColumns = true;
            dgvdsbenhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List<string> tenBacSi = new List<string>
    {
        "Nguyen Thi E", "Le Thi G",
        "Nguyễn Ngọc Phương Trâm", "Đoàn Thúy ko", "Tran Van F",
        "Đoàn Thúy Vy", "Pham Thi D", "Pham Thi H",
        "Tô Thúy Vy", "Dương Tô Quỳnh Như"
    };

            // Thêm tên các bác sĩ vào ComboBox
            foreach (string ten in tenBacSi)
            {
                cbbbacsi.Items.Add(ten);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_data2();
        }
    }
    }
    


