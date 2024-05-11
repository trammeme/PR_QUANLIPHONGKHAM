using DOANPK.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class frmDKLK : Form
    {
        private static Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        DKLKBUS dkk = new DKLKBUS();
        private DateTime chongDateTime;
        public frmDKLK()
        {
            InitializeComponent();
        }


       

       
       


        private void cbbchongiok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmalkrd.Text) ||
       string.IsNullOrWhiteSpace(txthoten.Text) ||
       string.IsNullOrWhiteSpace(txtemail.Text) ||
       cbchonbacsi.SelectedItem == null ||
       cbboxchuyenghanh.SelectedItem == null ||
       cbbchongiok.SelectedItem == null ||
       string.IsNullOrWhiteSpace(txttrieuchung.Text))
            {
                // Hiển thị hộp thoại cảnh báo
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng việc thực hiện tiếp theo nếu có trường thông tin chưa nhập
            }
            if (!string.IsNullOrEmpty(txtmalkrd.Text))
            {
                DateTime ngayDK = DateTime.Now;
                DateTime nsbn = dtngaysinh.Value;
                DateTime nk = dtlichkham.Value;
                String chonbs = cbchonbacsi.SelectedItem?.ToString(); // Sử dụng SelectedItem
                String chck = cbboxchuyenghanh.SelectedItem?.ToString(); // Sử dụng SelectedItem
                String giok = cbbchongiok.SelectedItem?.ToString(); // Sử dụng SelectedItem


                if (!string.IsNullOrEmpty(txtmalkrd.Text))
                {


                    if (dkk.themlk(txtmalkrd.Text, txthoten.Text, nsbn, txtemail.Text, chck, chonbs, nk, giok, ngayDK, txttrieuchung.Text)) // Pass chongDateTime
                    {
                        txtmalkrd.Clear();
                        txtemail.Clear();
                        txthoten.Clear();
                        txttrieuchung.Clear();
                        cbchonbacsi.Items.Clear();
                        cbboxchuyenghanh.Items.Clear();
                        cbbchongiok.Items.Clear();
                        // Xóa dữ liệu trong các DateTimePicker
                        dtngaysinh.Value = DateTime.Now;
                        dtlichkham.Value = DateTime.Now;
                        MessageBox.Show("Chúng tôi sẽ gửi chi tiết lịch khám sang email của bạn sau 24h vui lòng kiểm tra email.\nXin cảm ơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm!", "Thông báo đăng kí thành công ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                  
                }
        }
        private void randomma_Click(object sender, EventArgs e)
        {

            string randomCode = GenerateRandomCode("LK0", 2); 
            txtmalkrd.Text = randomCode; 
        }
        public static string GenerateRandomCode(string prefix, int length)
        {
            string randomString = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return prefix + randomString;
        }

        private Dictionary<string, List<string>> bacSiTheoKhoa = new Dictionary<string, List<string>>();

        private void frmDKLK_Load_1(object sender, EventArgs e)
        {
            bacSiTheoKhoa.Add("Khoa Nhi", new List<string> { "tô Thúy Vy", "Dương Tô Quỳnh Như" });
            bacSiTheoKhoa.Add("Khoa Nội", new List<string> { "Đoàn Thúy Vy", "Pham Thi D", "Pham Thi H" });
            bacSiTheoKhoa.Add("Khoa Thần Kinh", new List<string> { "Nguyễn Ngọc Phương Trâm", "Đoàn Thúy ko", "Tran Van F" });
            bacSiTheoKhoa.Add("Khoa Da Liễu", new List<string> { "Nguyen Thi E", "Le Thi G" });

            cbboxchuyenghanh.Items.Add("Khoa Nhi");
            cbboxchuyenghanh.Items.Add("Khoa Nội");
            cbboxchuyenghanh.Items.Add("Khoa Thần Kinh");
            cbboxchuyenghanh.Items.Add("Khoa Da Liễu");

            cbchonbacsi.DropDownStyle = ComboBoxStyle.DropDown;
            for (int i = 8; i <= 18; i++)
            {
                for (int j = 0; j <= 30; j += 30) 
                {
                    string time = $"{i:D2}:{j:D2}";
                    cbbchongiok.Items.Add(time);
                }
            }
        }

        private void btnhuydk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbboxchuyenghanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbchonbacsi.Items.Clear();

            string selectedKhoa = cbboxchuyenghanh.SelectedItem.ToString();

            if (bacSiTheoKhoa.ContainsKey(selectedKhoa))
            {
                foreach (string tenBacSi in bacSiTheoKhoa[selectedKhoa])
                {
                    cbchonbacsi.Items.Add(tenBacSi);
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin về khoa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

