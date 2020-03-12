using System;

namespace Helloworld
{
    class EmployeeWage
    {
            //constants
            int EMP_WAGE_PER_HRS = 20;
            int TOTAL_DAYS_IN_MONTH = 20;
            int MAX_WORKING_HOURS = 100;
            //variables
            int HOURS = 0;
            int DAYS = 0;
            int totalSalaryOfMonth=0;
            int totalHours = 0;
            int totalDays = 0;
            Random ran = new Random();
            int val;
            public void choice()
            {
                while (DAYS < TOTAL_DAYS_IN_MONTH && HOURS < MAX_WORKING_HOURS)
                {
                    DAYS++;
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
                    //calculating the total working hours
                    totalHours = totalHours + HOURS;
                    //calculating the total working days
                    totalDays = totalDays + DAYS;
               
                }
            Console.WriteLine("total working hours in month "+totalHours);
            }
        public static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.choice();
           
        }
    }
}