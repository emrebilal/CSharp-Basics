using System;
using System.Collections.Generic;
using System.Text;

namespace Work_5
{
    class VehicleLoanManager : ILoanManager
    {
        public void Calculate()
        {
            //...
            Console.WriteLine("Vehicle loan payment plan has been calculated.");
        }
        public void ViewLoan()
        {
            //...
            Console.WriteLine("Vehicle loan features...");
        }
    }
}
