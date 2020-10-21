using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius2e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            result01txtbox.Text = "";
            result02txtbox.Text = "";
            result03Atxtbox.Text = "";
            result04Atxtbox.Text = "";
            result05Atxtbox.Text = "";
            result06Atxtbox.Text = "";
            result07Atxtbox.Text = "";
            result08txtbox.Text = "";
            result09txtbox.Text = "";
            result10txtbox.Text = "";
            result11txtbox.Text = "";
            result12txtbox.Text = "";
            result13txtbox.Text = "";

            // #01
            decimal subtotal = Convert.ToDecimal(input01Atxtbox.Text);
            //result01txtbox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01txtbox.Text = (LogicalOperations.q01(subtotal)).ToString();

            // #02
            int timeInService = Convert.ToInt32(input02Atxtbox.Text);
            //result02txtbox.Text = (timeInService <= 4 || timeInService >= 12).ToString();
            result02txtbox.Text = (LogicalOperations.q02(timeInService)).ToString();

            // #03 - #06 initialization
            bool isValid = Convert.ToBoolean(input03Atxtbox.Text);
            int years = Convert.ToInt32(input03Ctxtbox.Text);


            // #03
            int counter = Convert.ToInt32(input03Btxtbox.Text);
            //result03Atxtbox.Text = (isValid == true && counter++ < years).ToString();
            result03Atxtbox.Text = (LogicalOperations.q03(isValid, years, counter)
                ).ToString();
            result03Btxtbox.Text = counter.ToString();

            // #04
             counter = Convert.ToInt32(input03Btxtbox.Text);
            //result04Atxtbox.Text = (isValid == true & counter++ < years).ToString();
            result04Atxtbox.Text = (LogicalOperations.q04(isValid, years, counter)).ToString();
            result04Btxtbox.Text = counter.ToString();

            // #05
             counter = Convert.ToInt32(input03Btxtbox.Text);
            result05Atxtbox.Text = (LogicalOperations.q05(isValid, years, counter)
                ).ToString();
            result05Btxtbox.Text = counter.ToString();

            // #06
            counter = Convert.ToInt32(input03Btxtbox.Text);
            result06Atxtbox.Text = (LogicalOperations.q06(isValid, years,counter)).ToString();
            result06Btxtbox.Text = counter.ToString();

            // #07
            DateTime startDate = Convert.ToDateTime(input07Atxtbox.Text);
            DateTime experationDate = Convert.ToDateTime(input07Btxtbox.Text);
            DateTime date = Convert.ToDateTime(input07Ctxtbox.Text);
            isValid = Convert.ToBoolean(input07Dtxtbox.Text);
            result07Atxtbox.Text = (LogicalOperations.q07(startDate, experationDate, date, isValid)).ToString();

            // #08
            decimal thisYTD = Convert.ToDecimal(input08Atxtbox.Text);
            decimal lastYTD = Convert.ToDecimal(input08Btxtbox.Text);
            string empType = input08Ctxtbox.Text;
            int startYear = Convert.ToInt32(input08Dtxtbox.Text);
            int currentYear = Convert.ToInt32(input08Etxtbox.Text);
            result08txtbox.Text = (LogicalOperations.q08(thisYTD,lastYTD, empType, startYear, currentYear)).ToString();

            // #09
            counter = Convert.ToInt32(input09Atxtbox.Text);
            years = Convert.ToInt32(input09Btxtbox.Text);
            result09txtbox.Text = (LogicalOperations.q09(counter, years)).ToString();
            result09tBxtbox.Text = counter.ToString();

            // #10
            int A =  Convert.ToInt32(input10Atxtbox.Text);
            int B = Convert.ToInt32(input10Btxtbox.Text);
            int C = Convert.ToInt32(input10Ctxtbox.Text);
            int D = Convert.ToInt32(input10Dtxtbox.Text);
            result10txtbox.Text = (LogicalOperations.q10(A, B, C, D)).ToString();

            // #11
            bool member = Convert.ToBoolean(input11Atxtbox.Text);
            decimal price = Convert.ToDecimal(input11Btxtbox.Text);
            float weight = Convert.ToSingle(input11Ctxtbox.Text);
            result11txtbox.Text = (LogicalOperations.q11(member, price, weight).ToString());

            // #12
             member = Convert.ToBoolean(input12Atxtbox.Text);
             price = Convert.ToDecimal(input12Btxtbox.Text);
             weight = Convert.ToSingle(input12Ctxtbox.Text);
            result12txtbox.Text = (LogicalOperations.q12(member, price, weight).ToString());

            // #13
            string shipstate = input13Atxtbox.Text;
            string itemtype = input13Btxtbox.Text;
            result13txtbox.Text = (LogicalOperations.q13(shipstate, itemtype).ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
