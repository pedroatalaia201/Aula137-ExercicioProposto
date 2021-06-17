using System;
using System.Globalization;
using System.Collections.Generic;
using Fixacao.Entities;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payers> taxPayer = new List<Payers>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c): ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: $");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'i')
                {
                    Console.Write("Health expenditures: $");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayer.Add(new Individual(name, income, health));
                }
                else
                {
                    Console.Write("Number of empoyees: ");
                    int employee = int.Parse(Console.ReadLine());

                    taxPayer.Add(new Company(name, income, employee));
                }
            }

            Console.WriteLine("TAXES PAID\n");
            double totalTaxe = 0;

            foreach(Payers payer in taxPayer)
            {
                Console.WriteLine(payer.Name + " $ " + payer.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxe += payer.Taxes();
            }

            Console.WriteLine("TOTAL TAXES: $" + totalTaxe.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
