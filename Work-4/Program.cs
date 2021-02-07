using System;

namespace Work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "123";
            customer1.IdentityNo = "9876543210";
            customer1.Name = "Emre";
            customer1.Surname = "Bilal";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNo = "1234";
            customer2.CompanyName = "TheEB";
            customer2.TaxNo = "001122334455";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            //customerManager.Add(customer3);
            //customerManager.Add(customer4);


        }
    }
}
