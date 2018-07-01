using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
   public class Ticket
    {


        public static long waitingTime1(int[] tickets, int p)
        {

            long result = 0;

            int currentIndex = 0;
            while (true)
            {

                if (currentIndex >= tickets.Length)
                    currentIndex = 0;

                //Sale
                tickets[currentIndex]--;
                result++;

                //Check and Remove
                if (tickets[currentIndex] == 0)
                {

                    if (currentIndex == p)
                        return result;

                    tickets = RemoveAt(tickets, currentIndex);
                    if (currentIndex < p)
                        p--;
                }
                else
                {
                    currentIndex = (currentIndex + 1 < tickets.Length) ? currentIndex + 1 : 0;
                }

                if (tickets[p] <= 0)
                    return result;
            }




        }

        public static int[] RemoveAt(int[] source, int index)
        {
            int[] result = new int[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, result, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, result, index, source.Length - index - 1);

            return result;
        }

        public static long waitingTime(int[] tickets, int p)
        {

            long result = 0;

            int needed = tickets[p];
            for (int i = 0; i < tickets.Length; i++)
            {
                if (i < p)
                {
                    if (tickets[i] < needed)
                        result += tickets[i];
                    else
                        result += needed;
                }
                else if (i > p)
                {
                    if (tickets[i] < needed-1)
                        result += tickets[i];
                    else
                        result += needed-1;
                }
                else
                {
                    result += tickets[p];
                }

            }

            return result;
        }




        

    }
}
