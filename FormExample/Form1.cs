using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0, sum = 0;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            sum = num1 + num2;
            lblAnswer.Text = "The answer is: " + sum;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0, subtract = 0;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            subtract = num1 - num2;
            lblAnswer.Text = "The answer is: " + subtract;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0, devide = 0;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            devide = num1 / num2;
            lblAnswer.Text = "The answer is: " + devide;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0, multiply = 0;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            multiply = num1 / num2;
            lblAnswer.Text = "The answer is: " + multiply;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu formM = new frmMenu();
            formM.Show();
            this.Hide();
        }
    }
}
