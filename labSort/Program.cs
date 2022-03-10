using System;

namespace labSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayGenerator.GenerateInt(5, 12, 23, 0.5, 2);
          // array = Quicksort.Sort(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
