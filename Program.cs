using System;

namespace InMarCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part I - Logical skills:
            //1) Write a program that loops through [1..100]. It should do the following:
            //a) If the number is divisible by 3, print “fizz”.
            //b) If divisible by 5 print “buzz”.
            //c) If divisible by 3 & 5, print “fizzbuzz”.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i.ToString() + "-fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i.ToString() + "-fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i.ToString() + "-buzz");
                }
            }

            //2) Reverse string "abcdef"
            Console.WriteLine("------------ Reverse String ----------------");
            string normalStr = "abcdef";
            string reverseStr = string.Empty;
            char[] strArray = normalStr.ToCharArray();
            for (int i = strArray.Length - 1; i > -1; i--)
            {
                reverseStr += strArray[i];
            }
            Console.WriteLine(normalStr + "|" + reverseStr);
            Console.ReadLine();
        }
    }
}
