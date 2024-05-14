namespace GUI
{
    partial class frmchucnang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnletan = new System.Windows.Forms.Button();
            this.btnds = new System.Windows.Forms.Button();
            this.btnbs = new System.Windows.Forms.Button();
            this.btnql = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qunalicatruc = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlibenhnhan = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlinhanvine = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlilichkham = new System.Windows.Forms.ToolStripMenuItem();
            this.paneljg = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnletan);
            this.panel2.Controls.Add(this.btnds);
            this.panel2.Controls.Add(this.btnbs);
            this.panel2.Controls.Add(this.btnql);
            this.panel2.Location = new System.Drawing.Point(12, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 856);
            this.panel2.TabIndex = 1;
            // 
            // btnletan
            // 
            this.btnletan.BackColor = System.Drawing.Color.Teal;
            this.btnletan.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnletan.ForeColor = System.Drawing.Color.SeaShell;
            this.btnletan.Location = new System.Drawing.Point(21, 286);
            this.btnletan.Name = "btnletan";
            this.btnletan.Size = new System.Drawing.Size(173, 55);
            this.btnletan.TabIndex = 3;
            this.btnletan.Text = "LỄ TÂN";
            this.btnletan.UseVisualStyleBackColor = false;
            this.btnletan.Click += new System.EventHandler(this.btnletan_Click);
            // 
            // btnds
            // 
            this.btnds.BackColor = System.Drawing.Color.Teal;
            this.btnds.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnds.ForeColor = System.Drawing.Color.SeaShell;
            this.btnds.Location = new System.Drawing.Point(21, 197);
            this.btnds.Name = "btnds";
            this.btnds.Size = new System.Drawing.Size(173, 55);
            this.btnds.TabIndex = 2;
            this.btnds.Text = "DƯỢC SĨ";
            this.btnds.UseVisualStyleBackColor = false;
            this.btnds.Click += new System.EventHandler(this.btnds_Click);
            // 
            // btnbs
            // 
            this.btnbs.BackColor = System.Drawing.Color.Teal;
            this.btnbs.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbs.ForeColor = System.Drawing.Color.SeaShell;
            this.btnbs.Location = new System.Drawing.Point(21, 116);
            this.btnbs.Name = "btnbs";
            this.btnbs.Size = new System.Drawing.Size(173, 55);
            this.btnbs.TabIndex = 1;
            this.btnbs.Text = "BÁC SĨ";
            this.btnbs.UseVisualStyleBackColor = false;
            this.btnbs.Click += new System.EventHandler(this.btnduocsi_Click);
            // 
            // btnql
            // 
            this.btnql.BackColor = System.Drawing.Color.Teal;
            this.btnql.ContextMenuStrip = this.contextMenuStrip1;
            this.btnql.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnql.ForeColor = System.Drawing.Color.SeaShell;
            this.btnql.Location = new System.Drawing.Point(21, 34);
            this.btnql.Name = "btnql";
            this.btnql.Size = new System.Drawing.Size(173, 55);
            this.btnql.TabIndex = 0;
            this.btnql.Text = "QUẢN LÍ";
            this.btnql.UseVisualStyleBackColor = false;
            this.btnql.Click += new System.EventHandler(this.btnql_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qunalicatruc,
            this.quanlibenhnhan,
            this.quanlinhanvine,
            this.quanlilichkham});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(253, 108);
            // 
            // qunalicatruc
            // 
            this.qunalicatruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.qunalicatruc.Name = "qunalicatruc";
            this.qunalicatruc.Size = new System.Drawing.Size(252, 26);
            this.qunalicatruc.Text = "Quản Lí Ca Trực ";
            this.qunalicatruc.Click += new System.EventHandler(this.qunalicatruc_Click);
            // 
            // quanlibenhnhan
            // 
            this.quanlibenhnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quanlibenhnhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quanlibenhnhan.Name = "quanlibenhnhan";
            this.quanlibenhnhan.Size = new System.Drawing.Size(252, 26);
            this.quanlibenhnhan.Text = "Quản Lí Bệnh Nhân";
            this.quanlibenhnhan.Click += new System.EventHandler(this.quanlibenhnhan_Click);
            // 
            // quanlinhanvine
            // 
            this.quanlinhanvine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.quanlinhanvine.Name = "quanlinhanvine";
            this.quanlinhanvine.Size = new System.Drawing.Size(252, 26);
            this.quanlinhanvine.Text = "Quản Lí Nhân Viên";
            this.quanlinhanvine.Click += new System.EventHandler(this.quanlinhanvine_Click);
            // 
            // quanlilichkham
            // 
            this.quanlilichkham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.quanlilichkham.Name = "quanlilichkham";
            this.quanlilichkham.Size = new System.Drawing.Size(252, 26);
            this.quanlilichkham.Text = "Quản Lí Lịch Khám";
            this.quanlilichkham.Click += new System.EventHandler(this.quanlilichkham_Click);
            // 
            // paneljg
            // 
            this.paneljg.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.paneljg.Location = new System.Drawing.Point(228, 3);
            this.paneljg.Name = "paneljg";
            this.paneljg.Size = new System.Drawing.Size(1874, 1040);
            this.paneljg.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.Ảnh_chụp_màn_hình_2024_05_14_1752441;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 182);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Circle", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(21, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "ĐĂNG XUẤT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmchucnang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.paneljg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmchucnang";
            this.Text = "frmchucnang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmchucnang_Load);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbs;
        private System.Windows.Forms.Button btnql;
        private System.Windows.Forms.Button btnds;
        private System.Windows.Forms.Button btnletan;
        private System.Windows.Forms.Panel paneljg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qunalicatruc;
        private System.Windows.Forms.ToolStripMenuItem quanlibenhnhan;
        private System.Windows.Forms.ToolStripMenuItem quanlinhanvine;
        private System.Windows.Forms.ToolStripMenuItem quanlilichkham;
        private System.Windows.Forms.Button button1;
    }
}