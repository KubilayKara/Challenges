using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> topSalers = new List<string>()
            //{ "hasan" ,"cemal","fatih"};
            //Console.WriteLine(topSalers.OrderBy(s => s).First());
            //Console.ReadLine();

            //List<List<int>> sch = new List<List<int>>()
            //{
            //    new List<int>(){ 0, 1 },
            //    new List<int>(){ 3, 5 },
            //    new List<int>(){ 4, 8 }
            //};
            //MergeSchedule(sch);

            //  Console.WriteLine(IsPalindrom(131) + " " + IsPalindrom(111) + " " + IsPalindrom(1521) + " " + IsPalindrom(125521));

            Console.WriteLine(SumOfPrimePalindromeNumbersDigits(200));
            Console.ReadLine();

        }


        public static string FindRepetitiveMaximumNumber(List<string> salesManager, List<int> salesCount)
        {

            int max = 0;
            List<string> topSalers = new List<string>();
            for (int i = 0; i < salesCount.Count; i++)
            {
                var currentSalesCount = salesCount[i];
                var currentSaler = salesManager[i];
                if (currentSalesCount > max)
                {
                    max = currentSalesCount;
                    topSalers = new List<string>();
                    topSalers.Add(currentSaler);

                }
                else if (currentSalesCount == max)
                {
                    topSalers.Add(currentSaler);
                }
            }

            return string.Format("{0} {1}", topSalers.OrderBy(s => s).First(), max);
        }


        public static List<List<int>> MergeSchedule(List<List<int>> scheduleList)
        {
            List<List<int>> result = new List<List<int>>();

            foreach (var itemToCheck in scheduleList.OrderBy(i => i[0]))
            {
                int start = itemToCheck[0];
                int end = itemToCheck[1];


                var itemsToChange = result.Where(l => start <= l[1] && end > l[1]);
                if (itemsToChange.Count() > 0)
                {
                    foreach (var itemToChange in itemsToChange)
                    {
                        itemToChange[1] = end;
                    }
                }
                else
                    result.Add(new List<int>() { start, end });

            }

            return result;
        }



        public static int SumOfPrimePalindromeNumbersDigits(int maxValue)
        {
            // SumPalindromNumbers metodu cagrilabilir 
            // ve uretilen sonuc SumOfDigits e yollanarak cikti return edilir.
            int total = SumPalindromNumbers(maxValue);
            return SumOfDigits(total);
        }

        private static string GetPalindrom(string value)
        {
            // disaridan verilen degeri tersine ceviren kodlarinizi yaziniz
            return string.Empty;
        }

        private static bool IsPalindrom(int number)
        {
            string numberAsString = number.ToString();
            for (int i = 0; i < numberAsString.Length / 2; i++)
            {
                if (numberAsString.Substring(i, 1) != numberAsString.Substring(numberAsString.Length - i - 1, 1))
                    return false;
            }
            return true;
        }

        private static bool IsAsal(int number)
        {
            // disaridan girilen number sayısının asal olup olmadıgını donunuz.

            if (number <= 1)
                return false;
            if (number < 100)
            {
                int[] firstPrimes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
                return firstPrimes.Any(p => p == number);
            }

            if (number % 2 == 0)
                return false;

            var tst = 2;
            while (tst * tst < number+1)
            {
                if (number % tst == 0)
                    return false;
                tst++;
            }


            return true;
        }

        private static int SumOfDigits(int total)
        {
            //disaridan girilen total degerin digit toplamini ureten kodu yaziniz
            string numberAsString = total.ToString();
            int result = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                result += int.Parse(numberAsString.Substring(i, 1));
            }
            return result;
        }

        private static int SumPalindromNumbers(int maxNumber)
        {
            // IsPalindrom metodundan yararlanarak palindrom sayiyi tespit ediniz.
            // 0'dan verilen maxNumber degerine kadarina olan asal ve palindrom sayıların toplamını donen kodu yazınız.

            int result = 0;
            for (int i = 0; i < maxNumber; i++)
            {
                if (IsPalindrom(i) && IsAsal(i))
                    result += i;
            }
            return result;
        }

    }
}
