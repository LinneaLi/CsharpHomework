using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }
       
        private void calculate(bool z)
        {
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2= decimal.Parse(txtNum2.Text);

            if (z) 
            {
                labAns.Text=(num1+ num2).ToString();
            }
            else
            {
                labAns.Text = (num1- num2).ToString();
            }
        }

        private void calculateMultiplyandDivide(bool X)
        {
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);

            if (X)
            {
                labAns.Text = (num1 * num2).ToString();
            }
            else
            {
                labAns.Text = (num1 / num2).ToString();
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            calculate(true);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calculate(false);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calculateMultiplyandDivide(true);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calculateMultiplyandDivide(false);
        }
    }
}
