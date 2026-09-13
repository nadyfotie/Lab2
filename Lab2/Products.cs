using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Products
    {
        public Products()
        {

        }
        public Products(string code, string desc, decimal price)
        {
            Code = code;
            Description = desc;
            Price = price;
        }

        public string Code { get; set; }
     
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string GetDisplayText(string sep)
        {
            return $"{Code}{sep}{Description}{sep}{Price.ToString("c")}";
        }

    }
}
