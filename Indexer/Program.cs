using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer sample = new Indexer();

            Console.WriteLine(sample[0] + " - " + sample[1]);

            Console.ReadLine();
        }
    }
    class Indexer
    {
        int[] sayilar = { 5, 10, 15, 20, 25 };
        public int this[int index]
        {
            get
            {
                return sayilar[index];
            }
            set
            {
                sayilar[index] = value;
            }
        }
    }
}
