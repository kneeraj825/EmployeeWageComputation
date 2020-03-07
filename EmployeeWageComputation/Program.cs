using System;

namespace Helloworld
{
    class Program
    {
        public static void Main(string[] args)
        {
            //constants
            int TOTAL_DAYS_IN_MONTH = 20;
            int HOURS = 0;
            int MAX_WORKING_HOURS = 100;
            int DAYS = 0;
            int totalSalaryOfMonth;
            int totalHours = 0;

            Random ran = new Random();
            int val;
            //calculating the days and hours not more than 20 and 100
            while (DAYS <= TOTAL_DAYS_IN_MONTH && HOURS <= MAX_WORKING_HOURS)
            {
                DAYS = (DAYS + 1);
                val = ran.Next(0, 3);
                switch (val)
                {
                    case 1:
                        HOURS = 8;
                        break;
                    case 2:
                        HOURS = 4;
                        break;
                    default:
                        HOURS = 0;
                        break;
                }
                totalHours = (totalHours + HOURS);
            }
            totalSalaryOfMonth = (TOTAL_DAYS_IN_MONTH * totalHours);
            Console.WriteLine("total salary of the month is "+totalSalaryOfMonth);

        }
    }
}