using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class MinMax
    {
        public void Method()
        {
            int[] arr = { 34,56,43,89,65,32,12,90,65,60 };

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Minimum element in the array is: " + min);
            Console.WriteLine("Maximum element in the array is: " + max);
        }
    }
}

  