namespace _22520853_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            bai1 bai01 = new bai1();
            bai01.Show();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            bai2 bai02 = new bai2();
            bai02.Show();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            bai3 bai03 = new bai3();
            bai03.Show();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            bai4 bai04 = new bai4();
            bai04.Show();
        }

        private void btn_bai7_Click(object sender, EventArgs e)
        {
            bai7 bai07 = new bai7();
            bai07.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
