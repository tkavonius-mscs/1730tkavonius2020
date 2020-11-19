using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;

namespace tkavonius2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                 date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            
            return  result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
               
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";



            DateTime date;
                 DateTime.TryParse(strDate, out date);
                result = date.ToShortDateString();
            
            
           


            return result;
        }
        public static string DateCalc09(string startDate, string endDate)
        {
            string result = "Invalid input";
            DateTime stdate;
            DateTime enDate;
            try
            {
                enDate = DateTime.Parse(endDate);
                stdate = DateTime.Parse(startDate);
              
               TimeSpan dayspast = stdate - enDate;
                result = dayspast.ToString();

                
            }
            catch { }


            return result;
        }
        public static string DateCalc10(string startDate, string endDate
            )
        {
            string result = "Invalid input";
            DateTime date;
            try
            {

                date = DateTime.Parse(startDate);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
        
            public static string StringCalc01(string s)
            {
                StringBuilder sb = new StringBuilder(100);
            string result = "Invalid input";
            try
            {
                sb.Remove(0, 1);
                sb.Insert(0, "cr");
                result = sb.ToString();
            }
            catch { }
                return result;

            }
            public static string StringCalc02(string s)
            {
            StringBuilder sb = new StringBuilder(100);
            string result = "Invalid input";
            try
            {
                sb.Remove(2,2);
                sb.Insert(0, "rit");
                result = sb.ToString();
            }
            catch { }
            return result;

        }

            public static string StringCalc03(string s)
            {
            string sb = "blue";
                string sc = sb.Substring(1).ToUpper();
            string result = "Invalid input";
            try
            {
                sb = sc;
                
            }
            catch { }
            return result;

        }

            public static string StringCalc04(string s)
            {
            string result = "Invalid input";
            try
            {
              

            }
            catch { }

            return "";

            }

            public static string StringCalc05(string s)
            {

            string result = s;
            result = result.Remove(0);
            result = result.Remove(4);
            result = result.Remove(8);
            try
            {
                

            }
            catch { }
            return s;

            }

            public static string StringCalc06(string s)
            {
                StringBuilder sb = new StringBuilder(100);

                return "";

            }

            public static string StringCalc07(string s)
            {
                StringBuilder sb = new StringBuilder(100);

                return "";

            }

            public static string StringCalc08(string s)
            {
                StringBuilder sb = new StringBuilder(100);

                return "";

            }
            public static string StringCalc09(string s)
            {
                StringBuilder sb = new StringBuilder(100);

                return "";

            }

            public static string StringCalc10(string s1, string s2, string s3)
            {
                StringBuilder sb = new StringBuilder(100);
                
                sb.Append(s1);
                sb.Append(s2);
                sb.Append(s3);
               
               
               
                return sb.ToString();

            }
        }
        
        }
    
