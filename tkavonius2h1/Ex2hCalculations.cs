using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace tkavonius2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "invalid input";
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
            string result = "invalid input";
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
            string result = "invalid input";



            DateTime date;
                 DateTime.TryParse(strDate, out date);
                result = date.ToShortDateString();
            
            
           


            return result;
        }
        public static string DateCalc09(string startDate, string endDate)
        {
            string result = "invalid input";
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
            string result = "invalid input";
            DateTime date;
            try
            {

                date = DateTime.Parse(startDate);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
    }
}