using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void OddEven()
        {
            // 4. Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.
            int[] arr2 = { 1, 2, 3, 4 };
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("The Number of Even number is : " + even);
            Console.WriteLine("The Number is Odd Number is : " + odd);
        }
    }
}
