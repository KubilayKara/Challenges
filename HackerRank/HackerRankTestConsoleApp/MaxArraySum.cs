using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTestConsoleApp
{
    public class MaxArraySum
    {
        //https://www.hackerrank.com/challenges/max-array-sum/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dynamic-programming

        public void Test()
        {
            Console.WriteLine("Sample Input 1:" + maxSubsetSum(new int[] { 2, 1, 5, 8, 4 }));
            Console.WriteLine("Sample Input 2:" + maxSubsetSum(new int[] { 3, 5, -7, 8, 10 }));
            Console.WriteLine("Sample Input 3:" + maxSubsetSum(new int[] { 2, 3, 2, -7, 8, 10 }));
            Console.WriteLine("Sample Input 4:" + maxSubsetSum(new int[] { 2, -3, 2, -7, 8, 10 }));
            Console.WriteLine("Sample Input 5:" + maxSubsetSum(new int[] { 2,1,8, 10, 8 }));
        }



        // Complete the maxSubsetSum function below.
        static int maxSubsetSum(int[] arr)
        {
            //discard negatives
            //
            return maxSubsetSum(arr, 0, new Dictionary<int, int>());
        }
        private static int maxSubsetSum(int[] arr, int startIndex, Dictionary<int, int> cach)
        {
            if (arr.Length <= startIndex)
            {
                return 0;
            }

            if (cach.ContainsKey(startIndex))
                return cach[startIndex];

            int currentValue = arr[startIndex];
            //IF Not Selected
            int sumIFNotSelected = maxSubsetSum(arr, startIndex + 1, cach);

            if (currentValue < 0)
            {
                cach[startIndex] = sumIFNotSelected;
                return sumIFNotSelected;
            }

            //if select
            int sumIFSelected = currentValue + maxSubsetSum(arr, startIndex + 2, cach);

            if (sumIFSelected > sumIFNotSelected)
            {
                cach[startIndex] = sumIFSelected;
                return sumIFSelected;
            }

            cach[startIndex] = sumIFNotSelected;
            return sumIFNotSelected;
        }
    }
}
