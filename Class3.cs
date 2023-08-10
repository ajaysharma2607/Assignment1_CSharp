using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void largest()
        {
            //3.Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.

            int[] arr = { 1, 2, 3, 4 };
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        s = arr[i];
                    }
                }
            }
            Console.WriteLine("Largest Element : " + s);
        }
    }
}
