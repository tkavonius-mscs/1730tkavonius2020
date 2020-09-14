using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius1f1
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            btnAustrailia.BackgroundImage = picAustrailia.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            lblCurrency.Text = (btnAustrailia.Text + ":") ;
            txtRate.Text = "0.727308";
            lblCurrency.Text = btnAustrailia.Text + ": ";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAustrailia_Click(object sender, EventArgs e)
        {
            btnAustrailia.BackgroundImage = picAustrailia.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            lblCurrency.Text = (btnAustrailia.Text + ":");
            txtRate.Text = "0.727308";
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnAustrailia.BackgroundImage = picAustrailiaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            lblCurrency.Text = (btnCanada.Text + ":");
            txtRate.Text = "0.761563";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnAustrailia.BackgroundImage = picAustrailiaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            lblCurrency.Text = (btnEuro.Text + ":");
            txtRate.Text = "1.18297";
        }

        private void btnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnAustrailia.BackgroundImage = picAustrailiaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            lblCurrency.Text = (btnJapan.Text + ":" );
            txtRate.Text = "0.00942341";
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSD.Text) + Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + "+"  + txtTotalUSD.Text;
        }

        private void lblEquation_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustrailia.BackgroundImage = picAustrailia.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            lblCurrency.Text = (btnAustrailia.Text + ":");
            txtRate.Text = "0.727308";
            lblCurrency.Text = btnAustrailia.Text + ": ";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
