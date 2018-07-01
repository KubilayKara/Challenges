using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop=false;
            while (!stop)
            {
                Console.WriteLine("Heyy inputs please");

                int n = Convert.ToInt32(Console.ReadLine());
                string[] a_temp = Console.ReadLine().Split(' ');

                int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                Sort(a);

                Console.WriteLine("Shoul Stop (Y\\N)");
                stop = Console.ReadLine().Trim().ToUpper() == "Y";


            }
        }

        private static void Sort(int[] inputs)
        {
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = 0; j < inputs.Length - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (inputs[j] > inputs[j + 1])
                    {
                        Swap(inputs, j, j + 1);
                        numberOfSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            Console.WriteLine(string.Format("Array is sorted in {0} swaps.", numberOfSwaps));
            //Array is sorted in numSwaps swaps. 

            Console.WriteLine(string.Format("First Element: {0}", inputs[0]));
            //First Element: firstElement

            Console.WriteLine(string.Format("Last Element: {0}", inputs[inputs.Length-1]));
            //Last Element: lastElement

        }

        private static void Swap<T>(T[] inputs, int index1, int index2)
        {
            T temp = inputs[index2];
            inputs[index2] = inputs[index1];
            inputs[index1] = temp;
        }
    }

}
