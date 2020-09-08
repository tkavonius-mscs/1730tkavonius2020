using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustrailia.Text = "0.00";
            txtRateAustrailia.Text = "0.727308";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.18297";
            txtAmountYen.Text = "0.00";
            txtRateYen.Text = "0.00942341";
            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.761563";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (Convert.ToDecimal(txtAmountAustrailia.Text) * Convert.ToDecimal(txtRateAustrailia.Text)).ToString("0.00");
        }

        private void euroTextchanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)).ToString("0.00");
        }

        private void yenTextChanged(object sender, EventArgs e)
        {
            txtUSDYen.Text = (Convert.ToDecimal(txtAmountYen.Text) * Convert.ToDecimal(txtRateYen.Text)).ToString("0.00");
        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (Convert.ToDecimal(txtAmountCanada.Text) * Convert.ToDecimal(txtRateCanada.Text)).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDEuro.Text) + Convert.ToDecimal(txtUSDYen.Text) +
             Convert.ToDecimal(txtUSDCanada.Text))
                .ToString("0.00");
        }
    }
}
