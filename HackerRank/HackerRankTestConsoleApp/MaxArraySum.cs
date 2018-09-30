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

        }
    }
}
