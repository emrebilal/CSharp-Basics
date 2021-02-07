using System;

namespace Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> countries = new MyList<string>();
            countries.Add("Turkey");
            countries.Add("England");
            countries.Add("Germany");

            countries.View();
        }
    }
}
