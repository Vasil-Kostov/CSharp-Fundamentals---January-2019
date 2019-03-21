namespace _03.DetailPrinter
{
    using Contarcts;
    using System;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private IList<IEmployee> employees;

        public DetailsPrinter(IList<IEmployee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (var employee in this.employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
