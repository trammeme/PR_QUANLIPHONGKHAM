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


      


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            LoginBUS loginBUS = new LoginBUS();

            if (loginBUS.Login(userName, passWord))
            {
                this.Hide();

                frmQLBN = new frmQLBN();

                frmQLBN.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }
    }
   
    }

