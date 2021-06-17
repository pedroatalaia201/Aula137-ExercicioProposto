using System;

namespace Fixacao.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payers(string name, double income)
        {
            Name = name;
            AnualIncome = income;
        }

        public abstract double Taxes();
    }
}
