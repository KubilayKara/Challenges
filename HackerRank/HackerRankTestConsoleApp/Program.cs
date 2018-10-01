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

            Console.WriteLine("1: MaxArraySum\n2:ArrayManipulation");
            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    Array_Manipulation.Test();
                    break;
                default:
                    break;
            }
            
        }
    }
}
