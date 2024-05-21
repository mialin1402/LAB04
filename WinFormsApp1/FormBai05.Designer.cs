namespace WinFormsApp1
{
    partial class FormBai05
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
            tbURL = new TextBox();
            tbUsrName = new TextBox();
            tbPass = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rtbKetQua = new RichTextBox();
            SuspendLayout();
            // 
            // tbURL
            // 
            tbURL.Location = new Point(160, 12);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(486, 27);
            tbURL.TabIndex = 0;
            tbURL.Text = "https://nt106.uitiot.vn/auth/token";
            tbURL.TextChanged += tb_TextChanged;
            // 
            // tbUsrName
            // 
            tbUsrName.Location = new Point(160, 54);
            tbUsrName.Name = "tbUsrName";
            tbUsrName.Size = new Size(376, 27);
            tbUsrName.TabIndex = 1;
            tbUsrName.Text = "phatpt";
            tbUsrName.TextChanged += tb_TextChanged;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(160, 96);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(376, 27);
            tbPass.TabIndex = 2;
            tbPass.Text = "123456";
            tbPass.TextChanged += tb_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(542, 54);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 68);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 61);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 103);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(33, 156);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.Size = new Size(613, 202);
            rtbKetQua.TabIndex = 7;
            rtbKetQua.Text = "";
            // 
            // FormBai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 411);
            Controls.Add(rtbKetQua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbPass);
            Controls.Add(tbUsrName);
            Controls.Add(tbURL);
            Name = "FormBai05";
            Text = "FormBai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbURL;
        private TextBox tbUsrName;
        private TextBox tbPass;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox rtbKetQua;
    }
}