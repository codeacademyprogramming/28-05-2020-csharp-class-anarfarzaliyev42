using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        private double edv = 0.18;
        private double productPrice;
        private string _article;
        private double productPriceEdv;
        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public string Quantity { get; set; }


        public string Article
        {
            get
            {
                return _article;
            }
            set
            {
                _article = value;
                switch (_article.ToLower())
                {
                    case "laptop":

                        productPrice = 1400;

                        break;
                    case "sd-cadr":

                        productPrice = 30;

                        break;
                    case "usb-hab":

                        productPrice = 12;

                        break;
                    default:

                        productPrice = 0;

                        break;

                }
            }
        }

        public double CostCalculation(bool needEdv)
        {
            if (needEdv)
            {
                productPriceEdv = (productPrice * int.Parse(Quantity)) + productPrice * int.Parse(Quantity) * edv;
                return productPriceEdv;
            }
            else
            {
                productPriceEdv = productPrice * int.Parse(Quantity);
                return productPriceEdv;
            }
        }



    }
}
