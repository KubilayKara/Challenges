using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"1: MaxArraySum
2:ArrayManipulation
3:ArrayEqual");
            switch (Console.ReadLine())
            {
                case "1":
                    break;

                case "2":
                    Array_Manipulation.Test();
                    break;

                case "3":
                    ArrayEqual.Test();
                    break;
                default:
                    break;
            }
            
        }
    }
}
