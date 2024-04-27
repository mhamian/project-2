using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class RONDOM : Form
    {
        public RONDOM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int number1 = int.Parse (textBox1.Text.ToString());
            int number2 = int.Parse(textBox2.Text.ToString());
            Random rannum = new Random();
            double random = rannum.Next(number1,number2);
            label2.Text = random.ToString();
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rannum = new Random();
            double random = rannum.NextDouble();
            label1.Text = random.ToString();
        }
    }
}
