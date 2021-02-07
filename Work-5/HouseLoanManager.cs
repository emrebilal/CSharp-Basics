using System;
using System.Collections.Generic;
using System.Text;

namespace Work_5
{
    class HouseLoanManager : ILoanManager
    {
        public void Calculate()
        {
            //...
            Console.WriteLine("House loan payment plan has been calculated.");
        }
        public void ViewLoan()
        {
            //...
            Console.WriteLine("House loan features...");
        }
    }
}
