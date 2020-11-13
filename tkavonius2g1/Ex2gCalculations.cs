using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tkavonius2g1
{
    class Ex2gCalculations
    {
        public static string SwitchDefault01(string customerType)
        {
            // 1e) Switch with Default
            decimal discountpercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
                default:
                    discountpercent = .0m;
                    break;
            }
            return discountpercent.ToString("0.0");

        }
        public static string Switch01(string customerType)
        {
            // 1a) 'Switch' with no default 
            decimal discountpercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
            }
            return discountpercent.ToString("0.0");

        }
        public static string If01(string customerType)
        {
            // 1b) Seperate "if" statements
            decimal discountpercent = -1m;

            if (customerType == "R")
                discountpercent = .1m;
            if (customerType == "C")
                discountpercent = .2m;
            return discountpercent.ToString("0.0");
        }
        public static string ElseIf01(string customerType)
        {
            // 1c) Else If
            decimal discountpercent = -1m;

            if (customerType == "R")
                discountpercent = .1m;
            else if (customerType == "C")
                discountpercent = .2m;
            return discountpercent.ToString("0.0");
        }
        public static string NestedIf01(string customerType)
        {
            // 1d) Nested If-else
            decimal discountpercent = -1m;

            if (customerType == "R")
            {

                discountpercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {

                    discountpercent = .2m;
                }
            }
            return discountpercent.ToString("0.0");
            
        

            
        
             

            
        }
    }
}
