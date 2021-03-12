using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math math=new Math(2,3);
            //Console.WriteLine(math.Sum2());
            //Console.WriteLine(math.Sum(3, 4));

            var type = typeof(Math);

            //Math math = (Math)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(math.Sum(4, 5));
            //Console.WriteLine(math.Sum2());

            var instance = Activator.CreateInstance(type, 6, 5);

            MethodInfo methodInfo = instance.GetType().GetMethod("Sum2");

            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("------------------");
            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method name : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter : {0}", parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class Math
    {
        private int _num1;
        private int _num2;

        public Math(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public Math()
        {

        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Sum2()
        {
            return _num1 + _num2;
        }

        [MetodName("Multiply")]
        public int Multiply2()
        {
            return _num1 * _num2;
        }
    }

    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
