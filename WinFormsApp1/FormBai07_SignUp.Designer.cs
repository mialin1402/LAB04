namespace LAB5
{
    partial class FormBai07_SignUp
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
            groupBox1 = new GroupBox();
            tbPass = new TextBox();
            tbUsrName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            label9 = new Label();
            dateTimePicker = new DateTimePicker();
            cbLanguage = new ComboBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            label8 = new Label();
            tbLastName = new TextBox();
            label7 = new Label();
            tbFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 0;
            label1.Text = "Hôm nay ăn gì ?";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPass);
            groupBox1.Controls.Add(tbUsrName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 98);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(86, 56);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(367, 27);
            tbPass.TabIndex = 3;
            tbPass.Text = "123123123";
            // 
            // tbUsrName
            // 
            tbUsrName.Location = new Point(88, 23);
            tbUsrName.Name = "tbUsrName";
            tbUsrName.Size = new Size(367, 27);
            tbUsrName.TabIndex = 2;
            tbUsrName.Text = "Thanh Duy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(rbtnFemale);
            groupBox2.Controls.Add(rbtnMale);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dateTimePicker);
            groupBox2.Controls.Add(cbLanguage);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(tbPhone);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbLastName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbFirstName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(17, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 291);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Information";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 258);
            label10.Name = "label10";
            label10.Size = new Size(32, 20);
            label10.TabIndex = 17;
            label10.Text = "Sex";
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(212, 256);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(78, 24);
            rbtnFemale.TabIndex = 16;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            rbtnFemale.CheckedChanged += rbtnFemale_CheckedChanged;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(89, 256);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 15;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            rbtnMale.CheckedChanged += rbtnMale_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 219);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 14;
            label9.Text = "Birthday";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(81, 214);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // cbLanguage
            // 
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Items.AddRange(new object[] { "vietnam", "english" });
            cbLanguage.Location = new Point(81, 172);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(369, 28);
            cbLanguage.TabIndex = 12;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(81, 28);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(367, 27);
            tbEmail.TabIndex = 11;
            tbEmail.Text = "123@gmail.com";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(83, 133);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(367, 27);
            tbPhone.TabIndex = 10;
            tbPhone.Text = "123123123";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 136);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 9;
            label8.Text = "Phone";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(81, 94);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(367, 27);
            tbLastName.TabIndex = 8;
            tbLastName.Text = "Duy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 64);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 7;
            label7.Text = "First name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(81, 61);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(367, 27);
            tbFirstName.TabIndex = 6;
            tbFirstName.Text = "Thanh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 97);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 175);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 3;
            label5.Text = "Language";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 28);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(279, 469);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(379, 469);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormBai07_SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 505);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormBai07_SignUp";
            Text = "FormBai07_SignUp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox tbPass;
        private TextBox tbUsrName;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox tbPhone;
        private Label label8;
        private TextBox tbLastName;
        private Label label7;
        private TextBox tbFirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbEmail;
        private Label label9;
        private DateTimePicker dateTimePicker;
        private ComboBox cbLanguage;
        private Label label10;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Button btnSubmit;
        private Button btnClear;
    }
}