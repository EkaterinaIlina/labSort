using System;

namespace labSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayGenerator.GenerateInt(5, 12, 23, 0.5, 2);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine();
            array = Quicksort.Sort(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
