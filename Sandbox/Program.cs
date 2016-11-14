using System;
using System.Collections.Generic;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertCodeHere theCode = new InsertCodeHere();
            theCode.MyCode();

            List<Employee> ansatte = new List<Employee>();
            Worker Per = new Worker("Per");
            ansatte.Add(Per);
            JuniorManager Jens = new JuniorManager("Jens", 200);
            ansatte.Add(Jens);
            SeniorManager Floki = new SeniorManager("Floki", 7);
            ansatte.Add(Floki);

            foreach (Employee p in ansatte)
            {
                Console.WriteLine($"Månedsløn: {p.GetSalaryPerMonth()} Navn: {p.GetName()} Bonus: {p.GetBonusPerMonth()} Skal have bonus?: {p.IsBonusPaidOut()}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
