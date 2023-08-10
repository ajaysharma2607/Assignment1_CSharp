using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void reverse() 
        {
            //5.Implement a C# program that reverses the elements of an integer array using a loop.
            int[] arr3 = { 1, 2, 3, 4 };
            int k = 0;
            int l = arr3.Length - 1;
            int temp = 0;
            while (k < l)
            {
                temp = arr3[k];
                arr3[k] = arr3[l];
                arr3[l] = temp;
                k++;
                l--;
            }
            Console.Write("Reversed Array :  ");

            for (int m = 0; m < arr3.Length; m++)
            {
                Console.Write(arr3[m] + " ");

            }
            Console.WriteLine();
        }
    }
}
