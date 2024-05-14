using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frmchucnang : Form
    {
        private Timer blinkTimer;
        private Color[] colors = { Color.Red, Color.Lavender, Color.LightGreen, Color.Yellow, Color.HotPink, Color.LightBlue }; // Mảng màu chứa các màu bạn muốn các button chớp

        public frmchucnang()
        {
            InitializeComponent();
            InitializeBlinkTimer();
            btnql.ContextMenuStrip = contextMenuStrip1;


        }
        private void InitializeBlinkTimer()
        {
            blinkTimer = new Timer();
            blinkTimer.Interval = 500; 
            blinkTimer.Tick += BlinkTimer_Tick;
            blinkTimer.Start(); 
        }
        public void AdjustButtonsVisibility(string username)
        {
            btnql.Enabled = false;
            btnds.Enabled = false;
            btnbs.Enabled = false;
            btnletan.Enabled = false;

            switch (username)
            {
                case "NVQL":
                    btnql.Enabled = true;
                    break;
                case "NVBS":
                    btnbs.Enabled = true;
                    break;
                case "NVDS":
                    btnds.Enabled = true;
                    break;
                case "NVLT":
                    btnletan.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Không có form tương ứng với tên đăng nhập này!");
                    break;
            }

        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            Button[] buttons = { btnbs, btnds, btnql, btnletan  };

            foreach (Button button in buttons)
            {
                button.ForeColor = colors[new Random().Next(0, colors.Length)];
            }
        
    }

            private void btnql_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnql, new Point(0, btnql.Height));

          
        }

        private void btnduocsi_Click(object sender, EventArgs e)
        {
           frmtaobenhan frmtaobenhan = new frmtaobenhan();
            frmtaobenhan.TopLevel = false;
            frmtaobenhan.FormBorderStyle = FormBorderStyle.None;
            frmtaobenhan.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmtaobenhan);
            frmtaobenhan.Show();
        }

        private void frmchucnang_Load(object sender, EventArgs e)
        {

        }

        private void btnds_Click(object sender, EventArgs e)
        {
            frmxemthuoc frmxemthuoc = new frmxemthuoc();
            frmxemthuoc.TopLevel = false;
            frmxemthuoc.FormBorderStyle = FormBorderStyle.None;
            frmxemthuoc.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmxemthuoc);
            frmxemthuoc.Show();

        }

        private void btnletan_Click(object sender, EventArgs e)
        {
            frmDKLK frmDKLK = new frmDKLK();
            frmDKLK.TopLevel = false;
            frmDKLK.FormBorderStyle = FormBorderStyle.None;
            frmDKLK.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmDKLK);
            frmDKLK.Show();
        }

        
        

       
        private void quảnLíLịchKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlDKLK frmqlDKLK = new frmqlDKLK();
            frmqlDKLK.TopLevel = false;
            frmqlDKLK.FormBorderStyle = FormBorderStyle.None;
            frmqlDKLK.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmqlDKLK);
            frmqlDKLK.Show();
        }

        

       

       

        private void qunalicatruc_Click(object sender, EventArgs e)
        {
            frmCaTruc frmCaTruc = new frmCaTruc();
            frmCaTruc.TopLevel = false;
            frmCaTruc.FormBorderStyle = FormBorderStyle.None;
            frmCaTruc.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmCaTruc);
            frmCaTruc.Show();
        }

        private void quanlinhanvine_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();
            frmQLNV.TopLevel = false;
            frmQLNV.FormBorderStyle = FormBorderStyle.None;
            frmQLNV.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmQLNV);
            frmQLNV.Show();
        }

        private void quanlibenhnhan_Click(object sender, EventArgs e)
        {
            frmQLBN frmQLBN = new frmQLBN();
            frmQLBN.TopLevel = false;
            frmQLBN.FormBorderStyle = FormBorderStyle.None;
            frmQLBN.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmQLBN);

            frmQLBN.Show();
        }

        private void quanlilichkham_Click(object sender, EventArgs e)
        {
            frmqlDKLK frmqlDKLK = new frmqlDKLK();
            frmqlDKLK.TopLevel = false;
            frmqlDKLK.FormBorderStyle = FormBorderStyle.None;
            frmqlDKLK.Dock = DockStyle.Fill;
            paneljg.Controls.Add(frmqlDKLK);
            frmqlDKLK.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
    }

    


    
