using System;
using System.CodeDom;
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

            Invoice invoice = new Invoice("678904", "Alex", "Foxtrot")
            {
                Article = "USB-hab",
                Quantity = "6"
            };
            
            Console.WriteLine($"Price is: {invoice.CostCalculation(true)} AZN");
            
            Console.ReadKey();
        }
    }

   
 
}
