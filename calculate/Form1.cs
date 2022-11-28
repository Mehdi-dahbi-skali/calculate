using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class calculate : Form
    {
        int i;
        string I;
        int j;
        int op;
        public calculate()
        {
            InitializeComponent();
        }
        private void Aff(int I)
        {
            this.textBox1.Text += ""+I;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aff(1);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void calculate_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aff(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aff(3);
        }

        private void multiplaybtn_Click(object sender, EventArgs e)
        {
            i += int.Parse(this.textBox1.Text);
            this.textBox1.Text = "";
            op = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aff(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aff(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aff(6);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            i += int.Parse(this.textBox1.Text);
            this.textBox1.Text = "";
            op = 1;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Aff(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Aff(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Aff(9);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            i += int.Parse(this.textBox1.Text);
            this.textBox1.Text = "";
            op = 2;
            
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Aff(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            /* if (op == 2)
             {
                 I += (i + j).ToString();
             }
             j += int.Parse(this.textBox1.Text);
             I += (i + j).ToString();*/
            /*  if (op == 0)
              {
                  I += (i * j).ToString();
              }
              else if (op == 1)
              {
                  I += (i - j).ToString();
              }
              else if(op == 2)
              {
                  I += (i + j).ToString();
              }
            */
            j= int.Parse(this.textBox1.Text);
            if (op == 0)
            {
                I += (i * j).ToString();
            }
            else if (op == 1)
            {
                I += (i - j).ToString();
            }
            else if (op == 2)
            {
                I += (i + j).ToString();
            }
            else if (op == 3)
            {
                I += (i / j).ToString();
            }

            this.label1.Text = I;
            i = 0;
            j=0;
            I = "";
            this.textBox1.Text = "";
            
        }

        private void divise_Click(object sender, EventArgs e)
        {
            i += int.Parse(this.textBox1.Text);
            this.textBox1.Text = "";
            op = 3;
        }

        private void DEll_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void dell_nmb_Click(object sender, EventArgs e)
        {
           
        }
    }
}
