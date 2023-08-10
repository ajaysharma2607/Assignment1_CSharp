using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void common() {


            
                int[] array1 = { 1, 2, 3, 4, 5 };
                int[] array2 = { 3, 4, 5, 6, 7 };

                int[] commonElements = FindCommonElements(array1, array2);

                Console.WriteLine("Array 1: " + string.Join(", ", array1));
                Console.WriteLine("Array 2: " + string.Join(", ", array2));
                Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
            

            int[] FindCommonElements(int[] arr1, int[] arr2)
            {
                int minLength = Math.Min(arr1.Length, arr2.Length);
                int[] common = new int[minLength];
                int commonCount = 0;

                for (int i = 0; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            common[commonCount++] = arr1[i];
                            break; // Move to the next element in arr1
                        }
                    }
                }

                Array.Resize(ref common, commonCount); // Trim the array to the actual number of common elements
                return common;
            }
        }



    }

}


