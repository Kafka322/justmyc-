using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1;
            int value2;

            value1 =  Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Add(value1, value2));

            
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
