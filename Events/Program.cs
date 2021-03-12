using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product(50);
            laptop.ProductName = "Laptop";

            Product phone = new Product(50);
            phone.ProductName = "Phone";
            phone.StockControlEvent += Phone_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                laptop.Sell(10);
                phone.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();


        }

        private static void Phone_StockControlEvent()
        {
            Console.WriteLine("Phone about to finish!!!");
        }
    }
}
