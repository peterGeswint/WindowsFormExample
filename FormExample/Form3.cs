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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int itemNo = 100001;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtItemNo.Enabled = false;
            txtItemNo.Text = itemNo.ToString();
            cmbItems.Items.Add("Electronics");
            cmbItems.Items.Add("Furniture");
            cmbItems.Items.Add("Clothing");
            cmbItems.Items.Add("Household");
            cmbItems.Items.Add("Foods");
            lstItems.Items.Add("Item Number \t Item Desc  \t  Item Category");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtItemNo.Text = itemNo.ToString();
            lstItems.Items.Add(txtItemNo.Text +"\t\t"+ txtItem.Text + "\t\t " + cmbItems.SelectedItem.ToString()); itemNo++;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }
    }
}
