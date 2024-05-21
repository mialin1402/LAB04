namespace LAB5
{
    partial class FormBai07
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(140, 45);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(501, 305);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // FormBai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Name = "FormBai07";
            Text = "FormBai07";
            Load += FormBai07_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}