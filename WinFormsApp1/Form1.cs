namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBai05 formBai05 = new FormBai05();
            formBai05.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBai06 formBai06 = new FormBai06();
            formBai06.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormBai07 formBai07 = new FormBai07();
            formBai07.ShowDialog();
        }
    }
}