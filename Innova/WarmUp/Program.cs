using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ticket.waitingTime(new int[] { 2, 6, 3, 4,5 }, 2));
            Console.WriteLine(Ticket.waitingTime(new int[] { 5,5,2,3 },3));
            Console.WriteLine("hello everyone...");
            Console.ReadLine();
        }


        static string findNumber(int[] arr, int k)
        {

            foreach (var item in arr)
            {
                if (k == item)
                {
                    return("YES");
                }
            }
            return ("NO");
        }

        static int[] oddNumbers(int l, int r)
        {
            int oddStart = IsOdd(l) ? l : l + 1;

            int oddEnd = IsOdd(r) ? r : r- 1;

            int lenth = (oddEnd - oddStart) / 2 + 1;

            int[] result = new int[lenth];

            int current = oddStart;
            int index = 0;
            while (current <= oddEnd)
            {
                result[index] = current;
                current += 2;
                index++;
            }
            return result;

        }


        static bool IsOdd(int a)
        {
            return a % 2 != 0;
        }
    }
}
