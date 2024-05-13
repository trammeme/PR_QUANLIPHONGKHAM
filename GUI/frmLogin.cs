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
    public partial class frmLogin : Form
    {
        public frmQLBN frmQLBN { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private bool validateData()
        {
            errorProvider1.SetError(txtUsername, (txtUsername.Text == "") ? "Hãy nhập UserName" : "");
            errorProvider2.SetError(txtPassword, (txtPassword.Text == "") ? "Hãy nhập Password" : "");
            return (txtUsername.Text != "" && txtPassword.Text != "");
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!validateData())
            {
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool isValid = LoginBUS.Login(username, password);

            if (isValid)
            {
                MessageBox.Show("Đăng nhập thành công!");
                OpenCorrespondingForm(username);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }


        }
        public void OpenCorrespondingForm(string username)
        {
            frmchucnang frmchucnang = new frmchucnang();
            // Gán sự kiện để khi form chức năng đóng lại, hiện lại form đăng nhập
            frmchucnang.FormClosed += (s, args) => this.Show();
            // Hiển thị form chức năng
            frmchucnang.Show();

            // Điều chỉnh hiển thị các nút tương ứng với tên đăng nhập
            frmchucnang.AdjustButtonsVisibility(username);
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load_2(object sender, EventArgs e)
        {

        }
    }

}