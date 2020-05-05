using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class SD_cadr:IArticle
    {
        private string _name = "SD-cadr";
        public string Name
        {
            get
            {
                return _name;
            }
        }
        private int _price = 12;
        public double Price
        {
            get
            {
                return _price;
            }
        }
    }
}
