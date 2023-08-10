using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void search()
        {
            // 7.Write a C# program that searches for a specific value in an integer array using a loop and returns its index if found.

            int[] ar5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Console.WriteLine("Enter the number you want to search");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ar5.Length; i++)
            {
                if (n == ar5[i])
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Index of the number is :" + i);
                    break;
                }
            }
        }
    }
}
