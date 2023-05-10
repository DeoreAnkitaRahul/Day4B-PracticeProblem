using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_PracticeProblem
{
    public class Pattern
    {
        public void Method()
        {
            int i, j;
            for ( i = 8; i >= 1; i--)
            {
                for ( j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
       
        
    }   }
}
