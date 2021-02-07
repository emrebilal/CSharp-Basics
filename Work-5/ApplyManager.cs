using System;
using System.Collections.Generic;
using System.Text;

namespace Work_5
{
    class ApplyManager
    {
        //Method injection
        public void ApplyforLoan(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            //...
            loanManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void ViewLoans(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.ViewLoan();
            }
        }
    }
}
