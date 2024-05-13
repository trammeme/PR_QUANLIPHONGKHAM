using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
    public partial class frmgiaodienchinh : Form
    {
        private Timer timer;
        private int currentPosition;
        private string runningText = "Chào mừng bạn đến với Phòng khám EHelthy";
        private Font font = new Font("Arial", 20); // Phông chữ với kích thước lớn hơn
        private Timer blinkTimer;
        private Color[] colors = { Color.Red, Color.Lavender, Color.Cornsilk, Color.Yellow, Color.HotPink, Color.LightBlue }; // Mảng màu chứa các màu bạn muốn các button chớp


        public frmgiaodienchinh()
        {

            InitializeComponent();
            InitializeRunningText();
            InitializeBlinkTimer(); // Thêm dòng này để kích hoạt blinkTimer



        }
        private void InitializeRunningText()
        {
            currentPosition = 0;
            timer = new Timer();
            timer.Interval = 30; // Đặt tốc độ chạy của văn bản
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void InitializeBlinkTimer()
        {
            blinkTimer = new Timer();
            blinkTimer.Interval = 500;
            blinkTimer.Tick += BlinkTimer_Tick;
            blinkTimer.Start();
        }
        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            Button[] buttons = { button1, button2 };

            foreach (Button button in buttons)
            {
                button.ForeColor = colors[new Random().Next(0, colors.Length)];
            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Di chuyển văn bản
            currentPosition++;
            if (currentPosition >= Width)
            {
                currentPosition = -TextRenderer.MeasureText(runningText, font).Width;
            }
            Invalidate(); // Vẽ lại form để cập nhật vị trí của văn bản
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.DrawString(runningText, font, Brushes.White, currentPosition, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDKLK frmDKLK = new frmDKLK();
            frmDKLK.ShowDialog();
        }
    }

}


