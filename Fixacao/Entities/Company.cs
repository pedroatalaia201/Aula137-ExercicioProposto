using System;

namespace Fixacao.Entities
{
    class Company : Payers
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double income, int number) : base(name, income)
        {
            EmployeesNumber = number;
        }

        public override double Taxes()
        {
            double taxes = 0;

            if(EmployeesNumber <= 10)
            {
                taxes = AnualIncome * 0.16;
            }
            else
            {
                taxes = AnualIncome * 0.14;
            }

            return taxes;
        }
    }
}
