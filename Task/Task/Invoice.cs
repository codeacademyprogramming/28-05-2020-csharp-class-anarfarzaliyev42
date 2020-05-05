using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private double _productPrice=0;
        private string _article;
        private double edv = 0.18;
       private double finalPrice=0;
        private bool isProductExists = false;
        private IArticle[] articles = new IArticle[]
        {
            new Laptop(),
            new SD_cadr(),
            new USB_hab()
        };

        public string Article { 
            get
            {
                return _article;
            }
            set
            {
                _article = value;
                foreach (var article in articles)
                {
                    if (_article.ToLower() == article.Name.ToLower())
                    {
                        _productPrice = article.Price;
                        isProductExists = true;
                    }
                }
            }
        }
        public int Quantity { get; set; }
                
       
        public Invoice(int account,string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public Invoice()
        {

        }

        public void CostCalculation(bool needEdv)
        {
            if (isProductExists)
            {
                if (needEdv)
                {
                    finalPrice = _productPrice * Quantity + (_productPrice * Quantity * edv);
                    Console.WriteLine($"Price is: {finalPrice}");
                }
                else
                {
                    finalPrice = _productPrice * Quantity;
                    Console.WriteLine($"Price is: {finalPrice}");
                }
            }
            else
            {
                Console.WriteLine("Product not found");
            }
            
        }
    }
}
