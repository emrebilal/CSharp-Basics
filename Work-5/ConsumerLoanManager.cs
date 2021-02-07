using System;
using System.Collections.Generic;
using System.Text;

namespace Work_5
{
    class ConsumerLoanManager : ILoanManager
    {
        public void Calculate()
        {
            //...
            Console.WriteLine("Consumer loan payment plan has been calculated.");
        }
        public void ViewLoan()
        {
            //...
            Console.WriteLine("Consumer loan features...");
        }
    }
}
