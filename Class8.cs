using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void SecLarge()
        {
            //8. Develop a C# program that finds the second smallest element in an integer array using loops and sorting techniques.

            int[] arr6 = { 111, 13, 25, 9, 34, 1 };

            Array.Sort(arr6);

            Console.WriteLine("smallest element is " + arr6[0]);
            Console.WriteLine("second smallest element is " + arr6[1]);
        }
    }
}
