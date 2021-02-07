using System;
using System.Collections.Generic;
using System.Text;

namespace Work_5
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            //...
            Console.WriteLine("Logged in the file.");
        }
    }
}
