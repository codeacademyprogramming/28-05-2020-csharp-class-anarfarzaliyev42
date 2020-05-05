using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Laptop : IArticle
    {
        private string _name = "Laptop";
        public string Name { 
            get{
                return _name ;
            }
        }
        private int _price = 1400;
        public double Price
        {
            get
            {
                return _price;
            }
        }
    
    }
}
