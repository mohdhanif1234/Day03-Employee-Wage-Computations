﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class EmployeeWageComputation
    {
        static void Main(string[] args)
        {
            //constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.ReadLine();
            }
        }
    }
}
