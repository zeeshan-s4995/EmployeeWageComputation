﻿using System;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageComputation empObj = new EmpWageComputation();
            empObj.IsEmployeePresent();

        }
    }
}
