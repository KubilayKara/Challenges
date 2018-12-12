using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTestConsoleApp
{
    class ArrayEqual
    {
        //https://www.hackerrank.com/challenges/equal/problem
        public static void Test()
        {
            Console.WriteLine("Test 1:" + equal(new int[] { 10, 7, 12 }));
            Console.WriteLine("Test 2:" + equal(new int[] { 2,2, 3, 7 }));
            Console.WriteLine("Test 3:" + equal(new int[] { 1,5,5}));
        }

        static int equal(int[] arr)
        {
            int iteration = 0;
            //1 2 5  

            while (true)
            {
                int max = arr.Max();
                int min = arr.Min();
                if (max == min)
                    break;
                iteration++;

                int numberToAdd = FindNumberToAdd(min, max);
                AddAllButMax(arr, numberToAdd, max);
                
            }
            return iteration;
        }

        private static void AddAllButMax(int[] arr, int numberToAdd, int max)
        {
            bool maxSkiped = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max && !maxSkiped)
                {
                    maxSkiped = true;
                    continue;
                }
                arr[i] += numberToAdd;
            }
        }

        private static int FindNumberToAdd(int min, int max)
        {
            int dif = max - min;

            if (dif >= 5)
                return 5;

            if (dif >= 2)
                return 2;
            return 1;
        }


    }
}
