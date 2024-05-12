namespace GUI
{
    partial class frmxemthuoc
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
            System.Windows.Forms.Label maLMTLabel;
            this.dgvdsthuoc = new System.Windows.Forms.DataGridView();
            this.xemtatcathuoc = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.btnxemang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            maLMTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsthuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(910, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(557, 96);
            label1.TabIndex = 47;
            label1.Text = "Xem Thuốc";
            // 
            // maLMTLabel
            // 
            maLMTLabel.AutoSize = true;
            maLMTLabel.BackColor = System.Drawing.Color.Transparent;
            maLMTLabel.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLMTLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            maLMTLabel.Location = new System.Drawing.Point(532, 179);
            maLMTLabel.Name = "maLMTLabel";
            maLMTLabel.Size = new System.Drawing.Size(284, 54);
            maLMTLabel.TabIndex = 41;
            maLMTLabel.Text = "Mã Thuốc";
            // 
            // dgvdsthuoc
            // 
            this.dgvdsthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsthuoc.Location = new System.Drawing.Point(19, 52);
            this.dgvdsthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvdsthuoc.Name = "dgvdsthuoc";
            this.dgvdsthuoc.RowHeadersWidth = 51;
            this.dgvdsthuoc.RowTemplate.Height = 24;
            this.dgvdsthuoc.Size = new System.Drawing.Size(1151, 432);
            this.dgvdsthuoc.TabIndex = 17;
            // 
            // xemtatcathuoc
            // 
            this.xemtatcathuoc.BackColor = System.Drawing.Color.ForestGreen;
            this.xemtatcathuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xemtatcathuoc.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemtatcathuoc.ForeColor = System.Drawing.Color.LemonChiffon;
            this.xemtatcathuoc.Location = new System.Drawing.Point(541, 888);
            this.xemtatcathuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xemtatcathuoc.Name = "xemtatcathuoc";
            this.xemtatcathuoc.Size = new System.Drawing.Size(296, 62);
            this.xemtatcathuoc.TabIndex = 45;
            this.xemtatcathuoc.Text = "Xem Tất Cả Thuốc ";
            this.xemtatcathuoc.UseVisualStyleBackColor = false;
            this.xemtatcathuoc.Click += new System.EventHandler(this.xemtatcathuoc_Click);
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.Transparent;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btntrove.Location = new System.Drawing.Point(1, 4);
            this.btntrove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(71, 84);
            this.btntrove.TabIndex = 46;
            this.btntrove.Text = "↩️";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // txtmaloai
            // 
            this.txtmaloai.BackColor = System.Drawing.SystemColors.Info;
            this.txtmaloai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmaloai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmaloai.Location = new System.Drawing.Point(541, 272);
            this.txtmaloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(911, 39);
            this.txtmaloai.TabIndex = 42;
            // 
            // btnxemang
            // 
            this.btnxemang.BackColor = System.Drawing.Color.ForestGreen;
            this.btnxemang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemang.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemang.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnxemang.Location = new System.Drawing.Point(1496, 255);
            this.btnxemang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxemang.Name = "btnxemang";
            this.btnxemang.Size = new System.Drawing.Size(269, 74);
            this.btnxemang.TabIndex = 44;
            this.btnxemang.Text = "Tìm kiếm";
            this.btnxemang.UseVisualStyleBackColor = false;
            this.btnxemang.Click += new System.EventHandler(this.btnxemang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.dgvdsthuoc);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(541, 341);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1205, 516);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // frmxemthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::GUI.Properties.Resources.z5424641864757_b8bb1bc44014af8bf3f671db18df48bc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1779, 1050);
            this.Controls.Add(label1);
            this.Controls.Add(maLMTLabel);
            this.Controls.Add(this.xemtatcathuoc);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.btnxemang);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmxemthuoc";
            this.Text = "frmxemthuoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsthuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsthuoc;
        private System.Windows.Forms.Button xemtatcathuoc;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Button btnxemang;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}