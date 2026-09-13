using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public static class ProductService
    {
        public static IEnumerable<Products> GetProducts()
        {
            var products = new List<Products>
           {
               new Products("p1", "TV", 500),
               new Products("p2", "Tablet", 300),
               new Products("p3", "Laptop", 1000)

           };
            return products;


        }
    }
}
