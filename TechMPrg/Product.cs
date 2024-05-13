using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQty { get; set; }
        public double ProductDiscount { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("I am inside Product class display method");
        }

        public void Caclulate_price()
        {
            ProductPrice = 100;
            ProductQty = 20;
            int res=ProductPrice*ProductQty;
            Console.WriteLine("Total price of Product="+res  );
        }
    }
}

