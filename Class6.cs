using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void multiple()
        {
            //6. Create a C# program that multiplies each element in an integer array by a specified factor using a loop.

            int[] arr4 = { 1, 2, 3, 4, 5, 6, 6 };
            int mul = 1;
            for (int p = 0; p < arr4.Length; p++)
            {
                mul *= arr4[p];
            }
            Console.WriteLine("Multiples of array : " + mul);
        }
    }
}
