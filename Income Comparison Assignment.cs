using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1:");
            int annualSalary1 = (hourlyRate * hoursPerWeek) * 52;
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual salary of Person 2:");
            int annualSalary2 = (hourlyRate2 * hoursPerWeek2) * 52;
            Console.WriteLine(annualSalary2);
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool isHighPerson1 = false;
            if (annualSalary1 > annualSalary2)
                isHighPerson1 = true;
            else
                isHighPerson1 = false;
            Console.WriteLine(isHighPerson1);
        }
    }
}