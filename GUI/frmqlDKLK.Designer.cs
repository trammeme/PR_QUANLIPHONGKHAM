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
            this.dgvdklk = new System.Windows.Forms.DataGridView();
            this.btnxemlich = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdklk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdklk
            // 
            this.dgvdklk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdklk.Location = new System.Drawing.Point(-3, 118);
            this.dgvdklk.Name = "dgvdklk";
            this.dgvdklk.RowHeadersWidth = 51;
            this.dgvdklk.RowTemplate.Height = 24;
            this.dgvdklk.Size = new System.Drawing.Size(791, 236);
            this.dgvdklk.TabIndex = 0;
            // 
            // btnxemlich
            // 
            this.btnxemlich.Location = new System.Drawing.Point(12, 379);
            this.btnxemlich.Name = "btnxemlich";
            this.btnxemlich.Size = new System.Drawing.Size(167, 23);
            this.btnxemlich.TabIndex = 1;
            this.btnxemlich.Text = "Xem Lịch khám  ";
            this.btnxemlich.UseVisualStyleBackColor = true;
            this.btnxemlich.Click += new System.EventHandler(this.btnxemlich_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.labelControl1.Location = new System.Drawing.Point(283, -7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(339, 98);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = " Lịch Khám";
            // 
            // frmqlDKLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnxemlich);
            this.Controls.Add(this.dgvdklk);
            this.Name = "frmqlDKLK";
            this.Text = "frmqlDKLK";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdklk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdklk;
        private System.Windows.Forms.Button btnxemlich;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}