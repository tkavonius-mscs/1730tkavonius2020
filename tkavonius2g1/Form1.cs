using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcbutton_Click(object sender, EventArgs e)
        {
            // 1a) 'Switch' with no default 
            resultSwitch01Textbox.Text = Ex2gCalculations.Switch01(input1aTextbox.Text);

            // 1b) Seperate "if" statements
            resultIf01Textbox.Text = Ex2gCalculations.If01(input1aTextbox.Text);

            // 1c) Else If
            resultElseif01Textbox.Text = Ex2gCalculations.ElseIf01(input1aTextbox.Text);

            // 1d) Nested If-else
            resultNestedifelse01Textbox.Text = Ex2gCalculations.NestedIf01(input1aTextbox.Text);

            // 1e) Switch with Default
            resultSwitchDefault01Textbox.Text = Ex2gCalculations.SwitchDefault01(input1aTextbox.Text);
        }
    }
}
