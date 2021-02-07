using System;
using System.Collections.Generic;

namespace Work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplyManager applyManager = new ApplyManager();
            applyManager.ApplyforLoan(new VehicleLoanManager(), new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService()});
            //applyManager.ViewLoans(new List<ILoanManager> {new ConsumerLoanManager(), new HouseLoanManager(), new VehicleLoanManager()});
        }
    }
}
