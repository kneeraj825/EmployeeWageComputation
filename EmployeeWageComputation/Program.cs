using System;

namespace EmployeeWageComputation
{        
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;
            Random ran = new Random();
            int val = ran.Next(0, 3);
            if (val == IS_PRESENT)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
