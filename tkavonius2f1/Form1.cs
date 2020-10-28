using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
       


            // #1 if
            result1Textbox.Text = Ex2fCalculations.Calc01(input1aTextbox.Text);

            // #2 if {block}
          
            result2Textbox.Text = Ex2fCalculations.Calc02(input2aTextbox.Text);

            // #3 if else
          
            result3Textbox.Text = Ex2fCalculations.Calc03(input3aTextbox.Text);

            // #4 if else if
          
            result4Textbox.Text = Ex2fCalculations.Calc04(input4aTextbox.Text);

            // #5 Better Range Testing
         
            result5Textbox.Text = Ex2fCalculations.Calc05(input5aTextbox.Text);

            // #6 Nested if else
          
            result6Textbox.Text = Ex2fCalculations.Calc06(input6aTextbox.Text, input6bTextbox.Text);

            // #7 Input Validation

            result7Textbox.Text = Ex2fCalculations.Calc07(input7aTextbox.Text);

            // #08 Price * quant, ship
            result8Textbox.Text = Ex2fCalculations.Calc08(input8aTextbox.Text, input8bTextbox.Text);

            // #09 Difference * rate
            result9Textbox.Text = Ex2fCalculations.Calc09(input9aTextbox.Text, input9bTextbox.Text);


            // #10 Divide Large
            result10Textbox.Text = Ex2fCalculations.Calc10(input10aTextbox.Text, input10bTextbox.Text);


        }
    }
}
