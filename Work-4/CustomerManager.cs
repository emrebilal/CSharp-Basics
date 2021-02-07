using System;

namespace Work_4
{
    //Business Class
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            //...
            Console.WriteLine(customer.GetType().Name + " customer added.");
        }
    }
}