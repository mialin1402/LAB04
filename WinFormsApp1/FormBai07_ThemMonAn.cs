namespace LAB4
{
    public partial class FormBai07_ThemMonAn : Form
    {
        public FormBai07_ThemMonAn()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox textbox)
                    {
                        if (string.IsNullOrEmpty(textbox.Text))
                        {
                            MessageBox.Show("Nhập thiếu thông tin");
                            return;
                        }
                    }
                    else if (control is RichTextBox richTextBox)
                    {
                        if (string.IsNullOrEmpty(richTextBox.Text))
                        {
                            MessageBox.Show("Nhập thiếu thông tin");
                            return;
                        }
                    }
                }
            };

            func(Controls);
        }
    }
}
