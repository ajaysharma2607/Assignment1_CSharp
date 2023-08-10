using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CSharp
{
    partial class Assign
    {
        public void duplicate() {
            
              int[] inputArray = { 1, 2, 2, 3, 4, 4, 5, 6, 6 };
                int[] uniqueArray = RemoveDuplicates(inputArray);

                Console.WriteLine("Original Array: " + string.Join(", ", inputArray));
                Console.WriteLine("Array with Duplicates Removed: " + string.Join(", ", uniqueArray));

              int[] RemoveDuplicates(int[] arr)
            {
                HashSet<int> uniqueSet = new HashSet<int>();
                List<int> uniqueList = new List<int>();

                foreach (int num in arr)
                {
                    if (!uniqueSet.Contains(num))
                    {
                        uniqueSet.Add(num);
                        uniqueList.Add(num);
                    }
                }

                return uniqueList.ToArray();
            }
        }
    }
}

