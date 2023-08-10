using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void Avg()
        {
            //2. Create a C# program that calculates the average of values in a floating-point array using a loop.
            float[] a = { 1.5f, 5.6f, 6.9f, 8.9f };

            float sum1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum1 += a[i];
            }
            float avg = sum1 / a.Length;
            Console.WriteLine("Average of Array elements : " + avg);
        }
    }
}
