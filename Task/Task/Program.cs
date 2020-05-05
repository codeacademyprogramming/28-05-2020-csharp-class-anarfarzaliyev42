using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(678904, "Alex", "Foxtrot")
            {
                Article = "LaPtop",
                Quantity = 2

            };

            invoice.CostCalculation(false);
      
            Console.ReadKey();
        }
    }
}
