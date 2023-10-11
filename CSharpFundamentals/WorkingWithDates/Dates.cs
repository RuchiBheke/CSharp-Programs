using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.WorkingWithDates
{
    public class Dates
    {   
        public void Datetime()
        {
            var dateTime = new DateTime(2023, 07, 02);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("1 "+ now.Hour);
            Console.WriteLine("2 "+now.Minute);
            Console.WriteLine("3 "+now+"\t"+today);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("4 "+tomorrow+"\t"+yesterday);
            Console.WriteLine("5 "+dateTime);
            Console.WriteLine("6 "+now.ToLongDateString());
            Console.WriteLine("7 "+now.ToShortDateString());
            Console.WriteLine("8 "+now.ToLongTimeString());
            Console.WriteLine("9 "+now.ToString("yyyy-MM-dd HH:mm"));

            //TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            Console.WriteLine("\n"+"10 "+timeSpan+"\t"+timeSpan1+" "+TimeSpan.FromHours(23));


        }
    }
}
