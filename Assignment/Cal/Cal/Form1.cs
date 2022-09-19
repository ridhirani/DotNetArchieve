using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string option;
        double num1, num2;
        double res;
       
        private void btnDot_Click(object sender, EventArgs e)
        {
            if(!txtResult.Text.Contains("."))
            {
                txtResult.Text += "."; 
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtResult.Text);
            if (option.Equals("+"))
                res = num1 + num2;

            if (option.Equals("-"))
                res = num1 - num2;

            if (option.Equals("*"))
                res = num1 * num2;

            if (option.Equals("/"))
                res = num1 / num2;

            

            txtResult.Text = res + "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = " ";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }
    }
}
