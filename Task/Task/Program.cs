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


            
      
            Console.ReadKey();
        }
    }

    class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        private double edv=0.18;
        private double productPrice;
        private string _article;
        public string Article 
        {
            get
            {
                return _article;
            }
            set
            {
                switch(value)
                {
                    case "laptop":
                         productPrice=1400;
                        break;
                    case "sd-cadr":
                            productPrice=30;
                        break;
                    case "usb-hab":
                          productPrice=12;
                        break;
                    default:
                         productPrice=0;
                        break;

                }
            }
        }
        public string Quantity { get; set; }

        public Invoice (string account,string customer,string provider )
	{
            this.account=account;
            this.customer=customer;
            this.provider=provider;
	}

        public void CostCalculation(bool needEdv)
        {
            if(needEdv)
            {
            
            }
            else
            {

            }
        }


    }
   
}
