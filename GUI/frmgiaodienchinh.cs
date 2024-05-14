using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmgiaodienchinh : Form
    {
        private Timer timer;
        private int currentPosition;
       
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
            timer.Start();
        }

        private void InitializeBlinkTimer()
        {
            blinkTimer = new Timer();
            blinkTimer.Interval = 500;
            blinkTimer.Tick += BlinkTimer_Tick;
            blinkTimer.Start();
        }

       
        private int _cornerRadius = 20;

      public class RoundedPanel : Panel
{
    private int _cornerRadius = 20;

    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            _cornerRadius = value;
            this.Invalidate(); // Yêu cầu vẽ lại khi thay đổi giá trị góc bo tròn
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        GraphicsPath path = new GraphicsPath();
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

        int radius = _cornerRadius;

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);

        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            e.Graphics.FillPath(brush, path);
        }

        using (Pen pen = new Pen(this.ForeColor, 1))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }
}
        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            Button[] buttons = { button2 };

            foreach (Button button in buttons)
            {
                button.ForeColor = colors[new Random().Next(0, colors.Length)];
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
    }
}
