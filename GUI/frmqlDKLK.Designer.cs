namespace GUI
{
    partial class frmqlDKLK
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
            this.btnxemlich = new System.Windows.Forms.Button();
            this.dgvdklk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdklk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnxemlich
            // 
            this.btnxemlich.BackColor = System.Drawing.Color.LightCoral;
            this.btnxemlich.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemlich.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnxemlich.Location = new System.Drawing.Point(163, 615);
            this.btnxemlich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxemlich.Name = "btnxemlich";
            this.btnxemlich.Size = new System.Drawing.Size(259, 56);
            this.btnxemlich.TabIndex = 70;
            this.btnxemlich.Text = "Xem Lịch khám  ";
            this.btnxemlich.UseVisualStyleBackColor = false;
            this.btnxemlich.Click += new System.EventHandler(this.btnxemlich_Click_1);
            // 
            // dgvdklk
            // 
            this.dgvdklk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdklk.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdklk.Location = new System.Drawing.Point(163, 244);
            this.dgvdklk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvdklk.Name = "dgvdklk";
            this.dgvdklk.RowHeadersWidth = 51;
            this.dgvdklk.RowTemplate.Height = 24;
            this.dgvdklk.Size = new System.Drawing.Size(1054, 324);
            this.dgvdklk.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(504, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 59);
            this.label1.TabIndex = 73;
            this.label1.Text = "Lịch Khám";
            // 
            // frmqlDKLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources._53fa149d77281a9965fe00735da988a0;
            this.ClientSize = new System.Drawing.Size(1924, 911);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxemlich);
            this.Controls.Add(this.dgvdklk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmqlDKLK";
            this.Text = "frmqlDKLK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvdklk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnxemlich;
        private System.Windows.Forms.DataGridView dgvdklk;
        private System.Windows.Forms.Label label1;
    }
}