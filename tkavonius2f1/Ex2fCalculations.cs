using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tkavonius2f1
{
   public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1 if

            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100) discountpercent = 0.2m;
            return discountpercent.ToString("n2");
        }
            public static string Calc02(string input)
                

            {
               // #2 if {block}
                decimal subtotal = 0.0m;
                decimal discountpercent = 0.0m;
                discountpercent = 0m;
                subtotal = Decimal.Parse(input);
                string status = "Standard Rate:";
                if (subtotal >= 100)
                {
                    discountpercent = 0.2m;
                    status = "Bulk Rate: " + discountpercent.ToString("n2");
                }
                return status;
            }

            public static string Calc03(string input)
            {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;

            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100m)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

            public static string Calc04(string input)
            {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;

            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountpercent = 0.2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountpercent = 0.3m;
            else if (subtotal >= 300)
                discountpercent = 0.4m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

            public static string Calc05(string input)
            {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;

            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 300)
                discountpercent = 0.4m;
            else if (subtotal >= 200)
                discountpercent = 0.3m;
            else if (subtotal >= 100)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

            public static string Calc06(string inputA, string inputB)
            {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;

            subtotal = Decimal.Parse(inputA);
            string customertype = inputB;
            discountpercent = 0m;
            if (customertype == "R")
            {
                if (subtotal >= 100)
                    discountpercent = 0.2m;
                else
                    discountpercent = 0.1m;
            }
            else        // customertype isn't "R"
                discountpercent = 0.4m;
            return discountpercent.ToString("n2");
        }

            public static string Calc07(string input)
            {
                // #7 Validate input: non-empty string
                if (input != "")
            {
                decimal ethereum = 0m;
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2") ;
            }
            return "Invalid Input";

            }

            public static string Calc08(string inputA, string inputB)
            {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal price = Decimal.Parse(inputA);
                decimal quantity = Decimal.Parse(inputB);
                total = quantity * price;
                if (total >= 50m)
                    return total.ToString("n2");
                else return (total + 5m).ToString("n2");
                    }
            return "Invalid Input";
            }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            if (inputA != "" && inputB != "" /*&& inputA < inputB*/)
            {
                decimal october = Decimal.Parse(inputA);
                decimal november = Decimal.Parse(inputB);
                decimal difference = november - october;
                decimal rate = .1m;
                decimal cost = difference * rate;
                return cost.ToString("n2");

            }
            return "Invalid Input";
            }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            double result = 0.0;
            if (inputA != "" && inputB != "")
                    {
                double smaller = Convert.ToDouble(inputA);
                double bigger = Convert.ToDouble(inputB);
                result = bigger / smaller;
                return result.ToString("n2");
            }
            return "Invailid Input";



            }

        }


    }

