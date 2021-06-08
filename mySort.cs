using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 1, -912, 123, 2, 4, 5, 0 };

            Sort(numbers);

            foreach(int val in numbers)
            {
                Console.WriteLine(val);
            }
            
        }

        static void Sort(int[] array) 
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int t = i; t < array.Length; t++)
                {
                    if(array[t] > array[i])
                    {
                        int val = array[t];
                        array[t] = array[i];
                        array[i] = val;
                    }
                }
            }
        }
    }
}
