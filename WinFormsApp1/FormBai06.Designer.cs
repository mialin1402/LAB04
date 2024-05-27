namespace LAB4
{
    partial class FormBai06
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
            btnGet = new Button();
            rtbKetQua = new RichTextBox();
            tbType = new TextBox();
            tbToken = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(604, 11);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 66);
            btnGet.TabIndex = 0;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(12, 87);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.Size = new Size(684, 245);
            rtbKetQua.TabIndex = 1;
            rtbKetQua.Text = "";
            // 
            // tbType
            // 
            tbType.Location = new Point(61, 11);
            tbType.Name = "tbType";
            tbType.Size = new Size(537, 27);
            tbType.TabIndex = 2;
            tbType.Text = "bearer";
            // 
            // tbToken
            // 
            tbToken.Location = new Point(61, 54);
            tbToken.Name = "tbToken";
            tbToken.Size = new Size(537, 27);
            tbToken.TabIndex = 3;
            tbToken.Text = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6InBoYXRwdCIsImV4cCI6MTcxNjM5ODY0NH0.XyccD0iZOI-RwcjKAS-Q-kXFnSz4hQ5W2_O-tLH8KXQ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 14);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 4;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Token";
            // 
            // FormBai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 353);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbToken);
            Controls.Add(tbType);
            Controls.Add(rtbKetQua);
            Controls.Add(btnGet);
            Name = "FormBai06";
            Text = "FormBai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGet;
        private RichTextBox rtbKetQua;
        private TextBox tbType;
        private TextBox tbToken;
        private Label label1;
        private Label label2;
    }
}