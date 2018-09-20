using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startMonth, startDay, startYear, endMonth, endDay, endYear;

            //User will able to type in the date with the proper format
            Console.WriteLine("Please enter a starting date in the format of mm/dd/yyyy.");

            string date1 = Console.ReadLine();
            string month1C = date1[0] + "" + date1[1];
            startMonth = int.Parse(month1C);
            string day1C = date1[3] + "" + date1[4];
            startDay = int.Parse(day1C);
            string year1C = date1[6] + "" + date1[7] + "" + date1[8] + "" + date1[9];
            startYear = int.Parse(year1C);
            // this for collecting the other date for the proper comparision
            Console.WriteLine("Please enter an ending date in the format of mm/dd/yyyy.");

            string date2 = Console.ReadLine();
            string month2C = date2[0] + "" + date2[1];
            endMonth = int.Parse(month2C);
            string day2C = date2[3] + "" + date2[4];
            endDay = int.Parse(day2C);
            string year2C = date2[6] + "" + date2[7] + "" + date2[8] + "" + date2[9];
            endYear = int.Parse(year2C);

            DateTime startDate = new DateTime(startYear, startMonth, startDay);
            DateTime endDate = new DateTime(endYear, endMonth, endDay);

            TimeSpan ts = endDate - startDate;

            int differenceInDays = Math.Abs(ts.Days);
            int differenceInHours = Math.Abs(differenceInDays * 24);
            int differenceInMinutes = Math.Abs(differenceInHours * 60);
            //Outcome will show the differences, it worked!
            Console.WriteLine("Difference in days: {0} ", differenceInDays);
            Console.WriteLine("Difference in hours: {0} ", differenceInHours);
            Console.WriteLine("Difference in minutes: {0} ", differenceInMinutes);
            Console.ReadLine();

        }

    }
}