using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius2D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassvaluesbtn_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "2";
            textBox6input.Text = "xyz";
            textBox7input.Text = "1";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "2";
            textBox9input.Text = "500";
            textBox10inputA.Text = "3";
            textBox10inputB.Text = "3";
        }

        private void setFailsValuesbtn_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xyz";
            textBox3input.Text = "2.4";
            textBox4input.Text = "true";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "3";
            textBox6input.Text = "Jones";
            textBox7input.Text = "0";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "1";
            textBox9input.Text = "499";
            textBox10inputA.Text = "4";
            textBox10inputB.Text = "3";
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            textBox1resultA.Text = "Fail";
            textBox2resultA.Text = "Fail";
            textBox3resultA.Text = "Fail";
            textBox4resultA.Text = "Fail";
            textBox5resultA.Text = "Fail";
            textBox6resultA.Text = "Fail";
            textBox7resultA.Text = "Fail";
            textBox8resultA.Text = "Fail";
            textBox9resultA.Text = "Fail";
            textBox10resultA.Text = "Fail";

            textBox1resultB.Text = "Success";
            textBox2resultB.Text = "Success";
            textBox3resultB.Text = "Success";
            textBox4resultB.Text = "Success";
            textBox5resultB.Text = "Success";
            textBox6resultB.Text = "Success";
            textBox7resultB.Text = "Success";
            textBox8resultB.Text = "Success";
            textBox9resultB.Text = "Success";
            textBox10resultB.Text = "Success";

            if (textBox1input.Text == "Frank")
                textBox1resultA.Text = "Success";
            if (textBox1input.Text != "Frank")
                textBox1resultB.Text = "Fail";

            if (textBox2input.Text == "")
                textBox2resultA.Text = "Success";
            if (textBox2input.Text != "")
                textBox2resultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3resultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3resultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4input.Text);
            if (val4 == false)
                textBox4resultA.Text = "Success";
            if (val4 != false)
                textBox4resultB.Text = "Fail";

            decimal val5a = Convert.ToDecimal(textBox5inputA.Text);
            decimal val5b = Convert.ToDecimal(textBox5inputB.Text);
            if (val5a == val5b)
                textBox5resultA.Text = "Success";
            if (val5a != val5b)
                textBox5resultB.Text = "Fail";

            if (textBox6input.Text != "Jones")
                textBox6resultA.Text = "Success";
            if (textBox6input.Text == "Jones")
                textBox6resultB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7input);
            if (val7 > 0m)
                textBox7resultA.Text = "Success";
            if (val7 < 0m)
                textBox7resultB.Text = "Fail";

            decimal val8a = Convert.ToDecimal(textBox8inputA.Text);
            decimal val8b = Convert.ToDecimal(textBox8inputB.Text);
            if (val8a < val8b)
                textBox8resultA.Text = "Success";
            if (val8a > val8b)
                textBox8resultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9input.Text);
            if (val9 >= 500m)
                textBox9resultA.Text = "Success";
            if (val9 <= 500m)
                textBox9resultB.Text = "Fail";

            decimal val10a = Convert.ToDecimal(textBox10inputA.Text);
            decimal val10b = Convert.ToDecimal(textBox10inputB.Text);
            if (val10a <= val10b)
                textBox10resultA.Text = "Success";
            if (val10a >= val10b)
                textBox10resultB.Text = "Fail";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
