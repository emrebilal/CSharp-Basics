using System;
using System.Collections.Generic;

namespace Work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(){Id = 1, CategoryId = 2, ProductName = "Notebook", UnitPrice = 500, UnitsInStock = 100};
            Product product2 = new Product(){Id = 2, CategoryId = 1, ProductName="Phone", UnitPrice = 900, UnitsInStock = 50};

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);

            Console.WriteLine("\nTotal: "+products.Count+"\n");

            foreach (var p in products)  
            {  
                Console.WriteLine("ID={0}, CategoryId={1}, ProductName={2}, UnitPrice={3}, UnitsInStock={4}", p.Id, p.CategoryId, p.ProductName, p.UnitPrice, p.UnitsInStock);  
            }
            
        }
    }
}
