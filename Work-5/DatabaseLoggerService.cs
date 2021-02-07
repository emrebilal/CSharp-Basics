using System;
using System.Collections.Generic;
using System.Text;

namespace Work_5
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            //...
            Console.WriteLine("Logged in the database.");
        }
    }
}
