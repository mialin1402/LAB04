namespace lab4_LTM
{
    partial class bai1
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
            tbURL = new TextBox();
            rtbWeb = new RichTextBox();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(536, 15);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(150, 46);
            btnGet.TabIndex = 0;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // tbURL
            // 
            tbURL.Location = new Point(27, 19);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(478, 39);
            tbURL.TabIndex = 1;
            // 
            // rtbWeb
            // 
            rtbWeb.Location = new Point(27, 86);
            rtbWeb.Name = "rtbWeb";
            rtbWeb.Size = new Size(728, 340);
            rtbWeb.TabIndex = 2;
            rtbWeb.Text = "";
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbWeb);
            Controls.Add(tbURL);
            Controls.Add(btnGet);
            Name = "bai1";
            Text = "bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGet;
        private TextBox tbURL;
        private RichTextBox rtbWeb;
    }
}