using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //ActionDemo();

            Func<int, int, int> add = Sum;

            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };


            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());

            //Console.WriteLine(Sum(2,3));

            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        private static void Find()
        {
            List<string> students = new List<string> { "Emre", "Emre_2", "Emre_3" };

            if (!students.Contains("Emre_4"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Emre", "Emre_2", "Emre_3" };
                students[3] = "Emre_4";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
