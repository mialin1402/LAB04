namespace LAB4
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            progressBar1 = new ProgressBar();
            dsMonAnMe = new FlowLayoutPanel();
            cbMePage = new ComboBox();
            label3 = new Label();
            cbMePageSize = new ComboBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            cbAllPage = new ComboBox();
            label4 = new Label();
            cbAllPageSize = new ComboBox();
            label5 = new Label();
            dsMonAnAll = new FlowLayoutPanel();
            label1 = new Label();
            btnThemMonAn = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(12, 135);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(876, 673);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(dsMonAnMe);
            tabPage1.Controls.Add(cbMePage);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cbMePageSize);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(868, 640);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Me";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(150, 606);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(471, 29);
            progressBar1.TabIndex = 6;
            // 
            // dsMonAnMe
            // 
            dsMonAnMe.Location = new Point(6, 6);
            dsMonAnMe.Name = "dsMonAnMe";
            dsMonAnMe.Size = new Size(856, 594);
            dsMonAnMe.TabIndex = 5;
            // 
            // cbMePage
            // 
            cbMePage.FormattingEnabled = true;
            cbMePage.Location = new Point(674, 606);
            cbMePage.Name = "cbMePage";
            cbMePage.Size = new Size(53, 28);
            cbMePage.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 610);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Page";
            // 
            // cbMePageSize
            // 
            cbMePageSize.FormattingEnabled = true;
            cbMePageSize.Location = new Point(809, 606);
            cbMePageSize.Name = "cbMePageSize";
            cbMePageSize.Size = new Size(53, 28);
            cbMePageSize.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(733, 609);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Page size";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbAllPage);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(cbAllPageSize);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dsMonAnAll);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(868, 640);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "All";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbAllPage
            // 
            cbAllPage.FormattingEnabled = true;
            cbAllPage.Location = new Point(674, 606);
            cbAllPage.Name = "cbAllPage";
            cbAllPage.Size = new Size(53, 28);
            cbAllPage.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(627, 610);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Page";
            // 
            // cbAllPageSize
            // 
            cbAllPageSize.FormattingEnabled = true;
            cbAllPageSize.Location = new Point(809, 606);
            cbAllPageSize.Name = "cbAllPageSize";
            cbAllPageSize.Size = new Size(53, 28);
            cbAllPageSize.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(733, 609);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Page size";
            // 
            // dsMonAnAll
            // 
            dsMonAnAll.Location = new Point(6, 6);
            dsMonAnAll.Name = "dsMonAnAll";
            dsMonAnAll.Size = new Size(856, 594);
            dsMonAnAll.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 2;
            label1.Text = "Hôm nay ăn gì ?";
            // 
            // btnThemMonAn
            // 
            btnThemMonAn.Location = new Point(742, 93);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(142, 65);
            btnThemMonAn.TabIndex = 3;
            btnThemMonAn.Text = "Thêm món ăn";
            btnThemMonAn.UseVisualStyleBackColor = true;
            btnThemMonAn.Click += btnThemMonAn_Click;
            // 
            // FormBai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 820);
            Controls.Add(btnThemMonAn);
            Controls.Add(label1);
            Controls.Add(tabControl);
            Name = "FormBai07";
            Text = "FormBai07";
            Load += FormBai07_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button btnThemMonAn;
        private ComboBox cbMePage;
        private Label label3;
        private ComboBox cbMePageSize;
        private Label label2;
        private FlowLayoutPanel dsMonAnMe;
        private ComboBox cbAllPage;
        private Label label4;
        private ComboBox cbAllPageSize;
        private Label label5;
        private FlowLayoutPanel dsMonAnAll;
        private ProgressBar progressBar1;
    }
}