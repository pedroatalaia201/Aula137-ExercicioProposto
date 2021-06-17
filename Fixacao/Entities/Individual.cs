using System;

namespace Fixacao.Entities
{
    class Individual : Payers
    {
        public double HealthExpen { get; set; }

        public Individual(string name, double income, double health) : base(name, income)
        {
            HealthExpen = health;
        }

        public override double Taxes()
        {
            double taxe = 0;

            if(AnualIncome <= 20000)
            {
                taxe = AnualIncome * 0.15;
            }
            else if(AnualIncome > 20000)
            {
                taxe = AnualIncome * 0.25;
            }
            if(HealthExpen != 0)
            {
                taxe = taxe - (HealthExpen * 0.5);
            }

            return taxe;
        }
    }
}
