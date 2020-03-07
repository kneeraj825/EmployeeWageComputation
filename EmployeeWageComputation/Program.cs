using System;

namespace Helloworld
{
    class Program
    {



        public static void Main(string[] args)
        {
            //constants
            int IS_ABSENT = 0;
            int EMP_WAGE_PER_HRS = 20;
            int EMP_FULL_TIME = 8;
            int EMP_PART_TIME = 4;
            Random ran = new Random();
            int val = ran.Next(0, 3);
            //calculating the salary using case statement
            switch (val)
            {
                case 1:
                    int FULL_DAY_SALARY = (EMP_WAGE_PER_HRS * EMP_FULL_TIME);
                    Console.WriteLine("total salary is " + FULL_DAY_SALARY);
                    break;
                case 2:
                    int PART_TIME_SALARY = (EMP_WAGE_PER_HRS * EMP_PART_TIME);
                    Console.WriteLine("total salary is " + PART_TIME_SALARY);
                    break;

                default:
                    Console.WriteLine("employee is absent");
                    Console.WriteLine("total salary is " + IS_ABSENT);
                    break;
            }
        }
    }
}