using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkavonius2c1
{
    public partial class Form1 : Form
    {
       private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        private void input2Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2Textbox.Text);
                byte2Textbox.Text = byte2.ToString();
            }
            catch (Exception) { byte2Textbox.Text = "error"; }
            try
            {
                sbyte2 = Convert.ToSByte(input2Textbox.Text);
                sbyte2Textbox.Text = sbyte2.ToString();
            }
            catch (Exception) { sbyte2Textbox.Text = "error"; }
            try
            {
                short2 = Convert.ToInt16(input2Textbox.Text);
                short2Textbox.Text = short2.ToString();
            }
            catch (Exception) { short2Textbox.Text = "error"; }
            try
            {
                ushort2 = Convert.ToUInt16(input2Textbox.Text);
                ushort2Textbox.Text = ushort2.ToString();
            }
            catch (Exception) { ushort2Textbox.Text = "error"; }
            try
            {
                int2 = Convert.ToInt32(input2Textbox.Text);
                int2Textbox.Text = int2.ToString();
            }
            catch (Exception) { int2Textbox.Text = "error"; }
            try
            {
                uint2 = Convert.ToUInt32(input2Textbox.Text);
                uint2Textbox.Text = uint2.ToString();
            }
            catch (Exception) { uint2Textbox.Text = "error"; }
            try
            {
                long2 = Convert.ToInt64(input2Textbox.Text);
                long2Textbox.Text = long2.ToString();
            }
            catch (Exception) { long2Textbox.Text = "error"; }
            try
            {
                ulong2 = Convert.ToUInt64(input2Textbox.Text);
                ulong2Textbox.Text = ulong2.ToString();
            }
            catch (Exception) { ulong2Textbox.Text = "error"; }
            try
            {
                float2 = Convert.ToSingle(input2Textbox.Text);
                float2Textbox.Text = float2.ToString();
            }
            catch (Exception) { float2Textbox.Text = "error"; }
            try
            {
                double2 = Convert.ToDouble(input2Textbox.Text);
                double2Textbox.Text = double2.ToString();
            }
            catch (Exception) { double2Textbox.Text = "error"; }
            try
            {
                decimal2 = Convert.ToDecimal(input2Textbox.Text);
                decimal2Textbox.Text = decimal2.ToString();
            }
            catch (Exception) { decimal2Textbox.Text = "error"; }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                byte3Textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3Textbox.Text = "error"; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                sbyte3Textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3Textbox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                short3Textbox.Text = short3.ToString();
            }
            catch (Exception) { short3Textbox.Text = "error"; }
            try
            {
                this.ushort3  = Convert.ToUInt16(this.ushort1 + this.ushort2);
                ushort3Textbox.Text = ushort3 .ToString();
            }
            catch (Exception) { ushort3Textbox.Text = "error"; }
            try
            {
                this.int3 = Convert.ToInt32(this.int1 + this.int2);
                int3Textbox.Text = int3.ToString();
            }
            catch (Exception) { int3Textbox.Text = "error"; }
            try
            {
                this.uint3 = Convert.ToUInt32(this.uint1 + this.uint2);
                uint3Textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3Textbox.Text = "error"; }
            try
            {
                this.long3 = Convert.Tolong32(this.uint1 + this.uint2);
                long3Textbox.Text = long3.ToString();
            }
            catch (Exception) { long3Textbox.Text = "error"; }
        }
    }

       
        public Form1()
        {
            InitializeComponent();

        }

        private void setMinbtn_Click(object sender, EventArgs e)
        {
            

            byte1 = Byte.MinValue;          byte1Textbox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; sbyte1Textbox.Text = sbyte1.ToString();
            short1 = Int16.MinValue; short1Textbox.Text = short1.ToString();
            ushort1 = UInt16.MinValue; ushort1Textbox.Text = ushort1.ToString();
            int1 = Int32.MinValue; int1Textbox.Text = int1.ToString();
            uint1 = UInt32.MinValue; uint1Textbox.Text = uint1.ToString();
            long1 = Int64.MinValue; long1Textbox.Text = long1.ToString();
            ulong1 = UInt64.MinValue; ulong1Textbox.Text = ulong1.ToString();
            float1 = Single.MinValue; float1Textbox.Text = float1.ToString();
            double1 = Double.MinValue; double1Textbox.Text = double1.ToString();
            decimal1 = Decimal.MinValue; decimal1Textbox.Text = decimal1.ToString();

           
        }

        private void setMaxbtn_Click(object sender, EventArgs e)
        {
          

            byte2 = Byte.MaxValue; byte2Textbox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; sbyte2Textbox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; short2Textbox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; ushort2Textbox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; int2Textbox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; uint2Textbox.Text = uint2.ToString();
            long2 = Int64.MaxValue; long2Textbox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; ulong2Textbox.Text = ulong2.ToString();
            float2 = Single.MaxValue; float2Textbox.Text = float2.ToString();
            double2 = Double.MaxValue; double2Textbox.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; decimal2Textbox.Text = decimal2.ToString();
        }

        private void input1Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte1 = Convert.ToByte(input1Textbox.Text);
                byte1Textbox.Text = byte1.ToString();
            }
            catch(Exception) { byte1Textbox.Text = "error"; }
            try
            {
               sbyte1 = Convert.ToSByte(input1Textbox.Text);
               sbyte1Textbox.Text =sbyte1.ToString();
            }
            catch (Exception) { sbyte1Textbox.Text = "error"; }
            try
            {
                short1 = Convert.ToInt16(input1Textbox.Text);
                short1Textbox.Text = short1.ToString();
            }
            catch (Exception) { short1Textbox.Text = "error"; }
            try
            {
               ushort1 = Convert.ToUInt16(input1Textbox.Text);
               ushort1Textbox.Text =ushort1.ToString();
            }
            catch (Exception) {ushort1Textbox.Text = "error"; }
            try
            {
                int1 = Convert.ToInt32(input1Textbox.Text);
                int1Textbox.Text = int1.ToString();
            }
            catch (Exception) { int1Textbox.Text = "error"; }
            try
            {
                uint1 = Convert.ToUInt32(input1Textbox.Text);
                uint1Textbox.Text = uint1.ToString();
            }
            catch (Exception) { uint1Textbox.Text = "error"; }
              try
            {
               long1 = Convert.ToInt64(input1Textbox.Text);
               long1Textbox.Text =long1.ToString();
            }
            catch (Exception) {long1Textbox.Text = "error"; }
            try
            {
                ulong1 = Convert.ToUInt64(input1Textbox.Text);
                ulong1Textbox.Text = ulong1.ToString();
            }
            catch (Exception) { ulong1Textbox.Text = "error"; }
            try
            {
                float1 = Convert.ToSingle(input1Textbox.Text);
                float1Textbox.Text = float1.ToString();
            }
            catch (Exception) { float1Textbox.Text = "error"; }
            try
            {
                double1 = Convert.ToDouble(input1Textbox.Text);
                double1Textbox.Text = double1.ToString();
            }
            catch (Exception) { double1Textbox.Text = "error"; }
            try
            {
                decimal1 = Convert.ToDecimal(input1Textbox.Text);
                decimal1Textbox.Text = decimal1.ToString();
            }
            catch (Exception) { decimal1Textbox.Text = "error"; }

        }
    }
}
