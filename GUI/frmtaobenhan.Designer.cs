namespace GUI
{
    partial class frmtaobenhan
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
            System.Windows.Forms.Label label1;
            this.dgvdsbenhan = new System.Windows.Forms.DataGridView();
            this.btnxemtatcaba = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtchuadoan = new System.Windows.Forms.TextBox();
            this.txtmabn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmaba = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbbacsi = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsbenhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Snow;
            label1.Location = new System.Drawing.Point(696, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(507, 81);
            label1.TabIndex = 47;
            label1.Text = "Tạo Bệnh Án";
            // 
            // dgvdsbenhan
            // 
            this.dgvdsbenhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsbenhan.Location = new System.Drawing.Point(94, 37);
            this.dgvdsbenhan.Name = "dgvdsbenhan";
            this.dgvdsbenhan.RowHeadersWidth = 51;
            this.dgvdsbenhan.RowTemplate.Height = 24;
            this.dgvdsbenhan.Size = new System.Drawing.Size(1074, 310);
            this.dgvdsbenhan.TabIndex = 17;
            this.dgvdsbenhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsbenhan_CellClick);
            // 
            // btnxemtatcaba
            // 
            this.btnxemtatcaba.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnxemtatcaba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxemtatcaba.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemtatcaba.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnxemtatcaba.Location = new System.Drawing.Point(94, 353);
            this.btnxemtatcaba.Name = "btnxemtatcaba";
            this.btnxemtatcaba.Size = new System.Drawing.Size(263, 50);
            this.btnxemtatcaba.TabIndex = 45;
            this.btnxemtatcaba.Text = "Xem Bệnh Án";
            this.btnxemtatcaba.UseVisualStyleBackColor = false;
            this.btnxemtatcaba.Click += new System.EventHandler(this.btnxemtatcaba_Click);
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.RosyBrown;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.Color.AliceBlue;
            this.btntrove.Location = new System.Drawing.Point(1, 993);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(201, 62);
            this.btntrove.TabIndex = 46;
            this.btntrove.Text = "Đăng Xuất";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dgvdsbenhan);
            this.groupBox1.Controls.Add(this.btnxemtatcaba);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(352, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 419);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(905, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 50);
            this.button2.TabIndex = 46;
            this.button2.Text = "Xem Bệnh Nhân";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightPink;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(352, 754);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 38);
            this.label6.TabIndex = 109;
            this.label6.Text = "Chuẩn Đoán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightPink;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(1014, 746);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 38);
            this.label7.TabIndex = 108;
            this.label7.Text = "Mã bệnh nhân:";
            // 
            // txtchuadoan
            // 
            this.txtchuadoan.BackColor = System.Drawing.Color.Gray;
            this.txtchuadoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchuadoan.ForeColor = System.Drawing.SystemColors.Control;
            this.txtchuadoan.Location = new System.Drawing.Point(566, 756);
            this.txtchuadoan.Name = "txtchuadoan";
            this.txtchuadoan.Size = new System.Drawing.Size(424, 34);
            this.txtchuadoan.TabIndex = 107;
            // 
            // txtmabn
            // 
            this.txtmabn.BackColor = System.Drawing.Color.Gray;
            this.txtmabn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmabn.Location = new System.Drawing.Point(1243, 748);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(370, 34);
            this.txtmabn.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightPink;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(352, 694);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 38);
            this.label4.TabIndex = 103;
            this.label4.Text = "Mã Bệnh Án:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightPink;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(1014, 697);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 38);
            this.label8.TabIndex = 100;
            this.label8.Text = "Bác Sĩ:";
            // 
            // txtmaba
            // 
            this.txtmaba.BackColor = System.Drawing.Color.Gray;
            this.txtmaba.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaba.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmaba.Location = new System.Drawing.Point(566, 698);
            this.txtmaba.Name = "txtmaba";
            this.txtmaba.Size = new System.Drawing.Size(424, 34);
            this.txtmaba.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(1243, 816);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 44);
            this.button1.TabIndex = 110;
            this.button1.Text = "Tạo Bệnh Án";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbbacsi
            // 
            this.cbbbacsi.BackColor = System.Drawing.Color.Gray;
            this.cbbbacsi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbbacsi.ForeColor = System.Drawing.SystemColors.Window;
            this.cbbbacsi.FormattingEnabled = true;
            this.cbbbacsi.Location = new System.Drawing.Point(1243, 701);
            this.cbbbacsi.Name = "cbbbacsi";
            this.cbbbacsi.Size = new System.Drawing.Size(370, 35);
            this.cbbbacsi.TabIndex = 111;
            // 
            // frmtaobenhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::GUI.Properties.Resources.z5424641845729_c8f42426e410e706b51f099fda01cd81;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1055);
            this.Controls.Add(this.cbbbacsi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtchuadoan);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmaba);
            this.Controls.Add(label1);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtaobenhan";
            this.Text = "frmtaobenhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmtaobenhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsbenhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsbenhan;
        private System.Windows.Forms.Button btnxemtatcaba;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtchuadoan;
        private System.Windows.Forms.TextBox txtmabn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmaba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbbacsi;
        private System.Windows.Forms.Button button2;
    }
}