using System;

namespace EmployeeWageComputation
{        
    class Program
    {
        static void Main(string[] args)
        {
            //constatns
            int IS_PRESENT = 1;
            int EMP_ABSENT = 0;
            int IS_PART_TIME = 2;
            int EMP_FULL_TIME = 8;
            int EMP_PART_TIME = 4;
            int EMP_WAGE_PER_HRS = 20;

            Random ran = new Random();
            int val = ran.Next(0, 3);
            //checking the salary of employee
            if (val == IS_PRESENT)
            {
                Console.WriteLine("employee is present");
                int FULL_DAY_SALARY = (EMP_WAGE_PER_HRS * EMP_FULL_TIME);
                Console.WriteLine("total salary is " + FULL_DAY_SALARY);
            }
            else if (val == IS_PART_TIME)
            {
                int PART_TIME_SALARY = (EMP_WAGE_PER_HRS * EMP_PART_TIME);
                Console.WriteLine("total salary is " + PART_TIME_SALARY);
            }
            else
            {
                Console.WriteLine("employee is absent");
                Console.WriteLine("total salary is " + EMP_ABSENT);
            }
            Console.WriteLine(val);
        }
    }
}
