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
    public partial class Orderform : Form
    {
        public Orderform()
        {
            InitializeComponent();
        }
        double price = 80;

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCheese.Checked)
            {
                price += 20;
                lblPrice.Text = "The Price is : " + price;
            }
            else
            {
                price -= 20;
                lblPrice.Text = "The Price is : " + price;
            }
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOnion.Checked)
            {
                price += 20;
                lblPrice.Text = "The Price is : " + price;
            }
            else
            {
                price -= 20;
                lblPrice.Text = "The Price is : " + price;
            }
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPepper.Checked)
            {
                price += 20;
                lblPrice.Text = "The Price is : " + price;
            }
            else
            {
                price -= 20;
                lblPrice.Text = "The Price is : " + price;
            }
        }

        private void chkSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSauce.Checked)
            {
                price += 20;
                lblPrice.Text = "The Price is : " + price;
            }
            else
            {
                price -= 20;
                lblPrice.Text = "The Price is : " + price;
            }

        }

        private void rdoDeliver_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeliver.Checked)
            {
                price += 15;
                lblPrice.Text = "The Price is : " + price;
            }
            else
            {
                price -= 15;
                lblPrice.Text = "The Price is : " + price;
            }
        }

        private void rdoDine_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDine.Checked)
            {
                price += 15;
                lblPrice.Text = "The Price is : " + price;
            }
            else
            {
                price -= 15;
                lblPrice.Text = "The Price is : " + price;
            }
        }

        private void rdoCollection_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCollection.Checked)
            {
                price += 15;
                lblPrice.Text = "The Price is : " + price;
            }
            else
            {
                price -= 15;
                lblPrice.Text = "The Price is : " + price;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu formMenu = new frmMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
