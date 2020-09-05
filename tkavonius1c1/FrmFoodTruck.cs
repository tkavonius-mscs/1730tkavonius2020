using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius1c1
{
    public partial class FrmFoodTruck : Form
    {
        public FrmFoodTruck()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotdogsSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotdogs.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
                5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = (
              Convert.ToDecimal(txtHotdogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
               ).ToString("0.00");
            txtTax.Text = (
              .0675m * Convert.ToDecimal(txtPretaxTotal.Text)).ToString("0.00")
                ;
            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)).ToString("0.00");

            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotdogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotdogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotdogs.Focus();

        }
    }
}
