using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? count = null; //or Nullable<int> count = null;

            if (count.HasValue)
            {
                Console.WriteLine("count: " + count.Value);
            }
            else
            {
                Console.WriteLine("count is null");
            }

            count = 10;

            if (count.HasValue)
            {
                Console.WriteLine("count: " + count.Value);
            }
            else
            {
                Console.WriteLine("count is null");
            }

            Console.ReadLine();
        }
    }
}
