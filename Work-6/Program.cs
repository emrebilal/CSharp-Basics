using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            //read and parse json data
            string data = File.ReadAllText("products.json");
            List<Product> tempProducts = JsonConvert.DeserializeObject<List<Product>>(data);

            if(tempProducts != null){
                foreach (var item in tempProducts)
                {
                    products.Add(new Product{Id = item.Id, ProductName = item.ProductName, ProductCategory = item.ProductCategory, Price = item.Price });
                }
            }

            //old data
            Console.WriteLine(data);

            //add product
            products.Add(new Product {Id = 3, ProductName = "iPhone", ProductCategory = "Mobile", Price = 1000});
            //write to json
            string newData = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText("products.json", newData);

            //new data
            foreach (var product in products)
            {
                 Console.WriteLine("{0} / {1} - {2}", product.ProductName, product.ProductCategory, product.Price);
            }

        }
    }
}
