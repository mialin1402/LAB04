namespace lab4_LTM
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 f = new bai1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 f = new bai2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bai3 f = new bai3();
            f.Show();
        }
    }
}
