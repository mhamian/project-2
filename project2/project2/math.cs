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
    public partial class math : Form
    {
        public math()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, X1, X2;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = b * b + 4 * a * c;
            if (d < 0)
            {
                label5.Text = " جواب ندارد " + d.ToString();
                label6.Text = " جواب ندارد " + d.ToString();
            }
            if (d == 0)
            {
                label5.Text = " یک جواب دارد :" + d.ToString();
            }
            if (d > 0)
            {
                X1 = (int)((-b + Math.Sqrt(d)) / (2 * a));
                X2 = (int)((-b - Math.Sqrt(d)) / (2 * a));

                label5.Text = "جواب اول : " + X1.ToString();
                label6.Text = "جواب دوم : " + X2.ToString();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
