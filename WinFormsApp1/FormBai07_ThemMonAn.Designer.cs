namespace LAB4
{
    partial class FormBai07_ThemMonAn
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
            label1 = new Label();
            tbMonAn = new TextBox();
            tbDiaChi = new TextBox();
            label2 = new Label();
            tbHinhAnh = new TextBox();
            label3 = new Label();
            tbGia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            rtbMoTa = new RichTextBox();
            label6 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Món ăn";
            // 
            // tbMonAn
            // 
            tbMonAn.Location = new Point(77, 56);
            tbMonAn.Name = "tbMonAn";
            tbMonAn.Size = new Size(393, 27);
            tbMonAn.TabIndex = 1;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(77, 122);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(393, 27);
            tbDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ";
            // 
            // tbHinhAnh
            // 
            tbHinhAnh.Location = new Point(77, 155);
            tbHinhAnh.Name = "tbHinhAnh";
            tbHinhAnh.Size = new Size(393, 27);
            tbHinhAnh.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Hình ảnh";
            // 
            // tbGia
            // 
            tbGia.Location = new Point(77, 89);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(393, 27);
            tbGia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 92);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 6;
            label4.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 8;
            label5.Text = "Mô tả";
            // 
            // rtbMoTa
            // 
            rtbMoTa.Location = new Point(77, 197);
            rtbMoTa.Name = "rtbMoTa";
            rtbMoTa.Size = new Size(393, 199);
            rtbMoTa.TabIndex = 9;
            rtbMoTa.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(127, 9);
            label6.Name = "label6";
            label6.Size = new Size(215, 40);
            label6.TabIndex = 10;
            label6.Text = "Thêm món ăn";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(376, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(276, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormBai07_ThemMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(rtbMoTa);
            Controls.Add(label5);
            Controls.Add(tbGia);
            Controls.Add(label4);
            Controls.Add(tbHinhAnh);
            Controls.Add(label3);
            Controls.Add(tbDiaChi);
            Controls.Add(label2);
            Controls.Add(tbMonAn);
            Controls.Add(label1);
            Name = "FormBai07_ThemMonAn";
            Text = "FormBai07_ThemMonAn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbMonAn;
        private TextBox tbDiaChi;
        private Label label2;
        private TextBox tbHinhAnh;
        private Label label3;
        private TextBox tbGia;
        private Label label4;
        private Label label5;
        private RichTextBox rtbMoTa;
        private Label label6;
        private Button btnAdd;
        private Button btnClear;
    }
}