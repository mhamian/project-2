namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RONDOM randompage = new RONDOM();
            randompage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            math mathpage = new math();
            mathpage.Show();
            this.Hide();
        }
    }
}
