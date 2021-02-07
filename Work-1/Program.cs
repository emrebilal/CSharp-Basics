using System;

namespace Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "ASUS Laptop";
            product1.Price = 1500;
            product1.Description = "Gamebook";

            Product product2 = new Product();
            product2.Name = "MSI Mouse";
            product2.Price = 250;
            product2.Description = "Game Mouse";

            Product[] products = new Product[]{product1,product2};

            foreach(var product in products){
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description + "\n");
            }

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Remove(product1);
        }
    }
}
