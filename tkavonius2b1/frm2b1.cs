using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius2b1
{
    public partial class frm2b1 : Form
    {
        public frm2b1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustrailia = Convert.ToDecimal(txtAmountAustrailia.Text);
            decimal rateAustrailia = 0.727308m;
            decimal usdAustrailia = amountAustrailia * rateAustrailia;
            txtUSDAustralia.Text = usdAustrailia.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = 1.18297m;
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = usdEuro.ToString("0.00");

            decimal amountYen = Convert.ToDecimal(txtAmountYen.Text);
            decimal rateYen = 0.00942341m;
            decimal usdYen = amountYen * rateYen;
            txtUSDYen.Text = usdYen.ToString("0.00");

            decimal amountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal rateCanada = 0.761563m;
            decimal usdCanada = amountCanada * rateCanada;
            txtUSDCanada.Text = usdCanada.ToString("0.00");

            decimal totalUSD = usdAustrailia + usdEuro + usdYen + usdCanada;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
        }
    }
    }

