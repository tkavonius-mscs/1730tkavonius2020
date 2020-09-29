using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius2A1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal DiscountPercent = 5m;
            decimal Subtotal = Convert.ToDecimal(txtSubtotal1.Text);
            decimal DiscountAmount = (Subtotal * DiscountPercent) / 100;
            txtDiscountAmount.Text = DiscountAmount.ToString("0.00");
            decimal Total = DiscountAmount + Subtotal;
            txtTotal.Text = Total.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
