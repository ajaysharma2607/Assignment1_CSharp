using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void sum()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine("Sum of elements of array : " + sum);
        }
        
    }
}
