namespace LAB4
{
    partial class FormBai07_MonAnItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            label1 = new Label();
            lbTenMonAn = new Label();
            lbGia = new Label();
            lbDiaChi = new Label();
            label3 = new Label();
            lbNguoiDongGop = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(150, 150);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 52);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 1;
            label1.Text = "Giá";
            // 
            // lbTenMonAn
            // 
            lbTenMonAn.AutoSize = true;
            lbTenMonAn.Font = new Font("JetBrains Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenMonAn.ForeColor = Color.IndianRed;
            lbTenMonAn.Location = new Point(178, 3);
            lbTenMonAn.Name = "lbTenMonAn";
            lbTenMonAn.Size = new Size(197, 40);
            lbTenMonAn.TabIndex = 3;
            lbTenMonAn.Text = "Tên Món Ăn";
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Location = new Point(261, 52);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(31, 20);
            lbGia.TabIndex = 4;
            lbGia.Text = "Gia";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(261, 84);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(53, 20);
            lbDiaChi.TabIndex = 6;
            lbDiaChi.Text = "DiaChi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 84);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Địa chỉ";
            // 
            // lbNguoiDongGop
            // 
            lbNguoiDongGop.AutoSize = true;
            lbNguoiDongGop.Location = new Point(261, 115);
            lbNguoiDongGop.Name = "lbNguoiDongGop";
            lbNguoiDongGop.Size = new Size(109, 20);
            lbNguoiDongGop.TabIndex = 8;
            lbNguoiDongGop.Text = "nguoidonggop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 115);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 7;
            label5.Text = "Đóng góp";
            // 
            // FormBai07_MonAnItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbNguoiDongGop);
            Controls.Add(label5);
            Controls.Add(lbDiaChi);
            Controls.Add(label3);
            Controls.Add(lbGia);
            Controls.Add(lbTenMonAn);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Name = "FormBai07_MonAnItem";
            Size = new Size(857, 160);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label label1;
        private Label lbTenMonAn;
        private Label lbGia;
        private Label lbDiaChi;
        private Label label3;
        private Label lbNguoiDongGop;
        private Label label5;
    }
}
