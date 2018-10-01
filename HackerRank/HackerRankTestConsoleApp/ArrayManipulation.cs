using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTestConsoleApp
{
    //https://www.hackerrank.com/challenges/crush/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    class Array_Manipulation
    {

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] result = new long[n];
            for (int i = 0; i < queries.Length; i++)
            {
                int start = queries[i][0];
                int end = queries[i][1];
                int value = queries[i][2];

                for (int j = start; j <= end; j++)
                {
                    result[j - 1] += value;
                }
            }

            return result.Max();

        }

       public static void Test()
        {
            int[][] q1 = new int[][] {
                new int[] { 2, 6, 8 },
                new int[] {3, 5 ,7 },
                new int[] {1, 8, 1 },
                new int[] {5, 9, 15}};

            Console.WriteLine("Result:" + arrayManipulation(10, q1));
            Console.ReadLine();

        }
    }
}
