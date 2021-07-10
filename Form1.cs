using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Proj_Manalo
{
    public partial class Form1 : Form
    {
        String num = "";
        String Opr = "";
        Double val = 0;
        Boolean prssdOpr = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void numDisp(String number)
        {
            if (prssdOpr)
            {
                num = numBox.Text;
                numBox.Text = "";
            }

            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            
            numBox.Text += number;
            prssdOpr = false;

        }
        private void num1_Click(object sender, EventArgs e)
        {
            numDisp("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            numDisp("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            numDisp("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            numDisp("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            numDisp("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            numDisp("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            numDisp("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            numDisp("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            numDisp("9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            numDisp("0");
        }

        private void period_Click(object sender, EventArgs e)
        {
            numDisp(".");
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            numBox.Text = "0";
        }

        private void opr_click(object sender, EventArgs e)
        {
            Button oprtr = (Button)sender;
            Opr = oprtr.Text;
            val = Double.Parse(numBox.Text);
            prssdOpr = true;

        }

        private void equalSign_Click(object sender, EventArgs e)
        {
            switch (Opr)
            {
                case "+":
                    numBox.Text = (val + Double.Parse(numBox.Text)).ToString();
                    break;

                case "-":
                    numBox.Text = (val - Double.Parse(numBox.Text)).ToString();
                    break;

                case "/":
                    numBox.Text = (val / Double.Parse(numBox.Text)).ToString();
                    break;

                case "*":
                    numBox.Text = (val * Double.Parse(numBox.Text)).ToString();
                    break;

                default:
                    break;
            }

            prssdOpr = false;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            numBox.Clear();
            numBox.Text = "0";
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            numBox.Text = Math.Sqrt(Convert.ToDouble(numBox.Text)).ToString();
        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            numBox.Text = Math.Pow(Convert.ToDouble(numBox.Text), 2).ToString();
        }
    }   
}
