namespace LAB5
{
    partial class FormBai07_Login
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
            label2 = new Label();
            tbUsrName = new TextBox();
            tbPass = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            lbSignUp = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbUsrName
            // 
            tbUsrName.Location = new Point(142, 41);
            tbUsrName.Name = "tbUsrName";
            tbUsrName.Size = new Size(246, 27);
            tbUsrName.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(142, 76);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(246, 27);
            tbPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(412, 44);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 59);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 133);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 5;
            label3.Text = "Dont have an account yet?";
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.ForeColor = SystemColors.MenuHighlight;
            lbSignUp.Location = new Point(293, 133);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(61, 20);
            lbSignUp.TabIndex = 6;
            lbSignUp.Text = "Sign Up";
            lbSignUp.Click += lbSignUp_Click;
            // 
            // FormBai07_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 189);
            Controls.Add(lbSignUp);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(tbPass);
            Controls.Add(tbUsrName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBai07_Login";
            Text = "FormBai07_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsrName;
        private TextBox tbPass;
        private Button btnLogin;
        private Label label3;
        private Label lbSignUp;
    }
}