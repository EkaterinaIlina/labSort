using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSort
{
    internal class Quicksort
    {


        public static int[] Sort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j-1])
                    {
                        temp = array[j];
                        array[j] = array[j-1];
                        array[j-1] = temp;
                    }
                }
            return array;
        }


        public static double[] Sort(double[] array)
        {
            double temp;
            for (int i = 0; i < array.Length; i++)
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            return array;
        }

   
    }
}
