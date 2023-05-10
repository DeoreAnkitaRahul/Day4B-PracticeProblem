using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class SumOfDigit
    {
        public void Method()
        {
            Console.Write("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, rem;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }

            Console.WriteLine($"The Sum of Digits is : {sum}");
            Console.ReadKey();
        }

    }
}

       
               
    


