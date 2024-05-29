namespace lab4_LTM
{
    partial class bai2
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
            rtbWeb = new RichTextBox();
            tbURL = new TextBox();
            btnDownload = new Button();
            tbAddressSaving = new TextBox();
            SuspendLayout();
            // 
            // rtbWeb
            // 
            rtbWeb.Location = new Point(23, 154);
            rtbWeb.Name = "rtbWeb";
            rtbWeb.Size = new Size(728, 340);
            rtbWeb.TabIndex = 5;
            rtbWeb.Text = "";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(36, 24);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(478, 39);
            tbURL.TabIndex = 4;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(553, 56);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(150, 46);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // tbAddressSaving
            // 
            tbAddressSaving.Location = new Point(36, 98);
            tbAddressSaving.Name = "tbAddressSaving";
            tbAddressSaving.Size = new Size(478, 39);
            tbAddressSaving.TabIndex = 6;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 529);
            Controls.Add(tbAddressSaving);
            Controls.Add(rtbWeb);
            Controls.Add(tbURL);
            Controls.Add(btnDownload);
            Name = "bai2";
            Text = "bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbWeb;
        private TextBox tbURL;
        private Button btnDownload;
        private TextBox tbAddressSaving;
    }
}