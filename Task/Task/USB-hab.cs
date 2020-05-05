using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class USB_hab:IArticle
    {
        private string _name = "USB-hab";
        public string Name
        {
            get
            {
                return _name;
            }
        }
        private int _price = 30;
        public double Price
        {
            get
            {
                return _price;
            }
        }
    }
}
