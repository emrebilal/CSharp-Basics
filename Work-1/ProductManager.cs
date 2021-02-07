using System;

namespace Work_1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            //...
            Console.WriteLine(product.Name + " added to cart.");
        }
        public void Remove(Product product)
        {
            //...
            Console.WriteLine($"{product.Name} removed from cart.");
        }
    }
}