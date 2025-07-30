using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CALCULATOR : Form
    {
        double firstno,secondno,ans;
        string op = "";
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void CALCULATOR_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_5_Click(object sender, EventArgs e)
        {

        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";

            }
            else
            {
                richTextBox1.Text += "0";
            }

        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";

            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";

            }
            else
            {
                richTextBox1.Text += "2";
            }

        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";

            }
            else
            {
                richTextBox1.Text += "3";
            }

        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";

            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void BTN_5_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";

            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";

            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";

            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";

            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "-";
        }

        private void MULTY_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "*";
        }

        private void DIVIDE_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "/";
        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            secondno = Convert.ToDouble(richTextBox1.Text);
            if (op == "+")
            {
                ans = firstno + secondno;
                richTextBox1.Text = ans.ToString();

            }
            else if (op == "-")
            {
                ans = firstno - secondno;
                richTextBox1.Text = ans.ToString();

            }
            else if (op == "X")
            {
                ans = firstno * secondno;
                richTextBox1.Text = ans.ToString();

            }

            else if (op == "/")
            {
                if (secondno != 0)
                {
                    ans = firstno / secondno;
                    richTextBox1.Text = ans.ToString();

                }
                else
                {
                    MessageBox.Show("Cannot divided by zero");
                    richTextBox1.Text = "0";
                }

            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";

            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            firstno=Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "+";
        }
    }
}
