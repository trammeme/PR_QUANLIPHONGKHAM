using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmgiaodienchinh : Form
    {
        private TextBox txtChatDisplay;
        private TextBox txtInput;
        private Button btnSend;

        private Timer blinkTimer;
        private Color[] colors = { Color.RosyBrown, Color.Beige, Color.LightGreen, Color.LightYellow, Color.LightPink, Color.DarkGray };

        public frmgiaodienchinh()
        {
            InitializeComponent();
            InitializeBlinkTimer();


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
            Button[] buttons = { button2 };

            foreach (Button button in buttons)
            {
                button.ForeColor = colors[new Random().Next(0, colors.Length)];
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtInput.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                txtChatDisplay.AppendText("Bạn: " + message + Environment.NewLine);
                txtInput.Clear();
            }
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form chatForm = new Form();
            chatForm.Text = "Trò chuyện tư vấn";
            chatForm.Size = new Size(450, 500);

            // Đặt vị trí của cửa sổ chat ở góc phải của màn hình
            chatForm.StartPosition = FormStartPosition.Manual;
            chatForm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - chatForm.Width, 0);

            // Tạo một Label để hiển thị văn bản chào mừng
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Xin chào! Bạn cần trợ giúp điều gì?";
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(10, 10);

            // Thêm Label vào form
            chatForm.Controls.Add(welcomeLabel);

            // Hiển thị cửa sổ trò chuyện tư vấn
            chatForm.ShowDialog();
        }

        
    }
}
