using System;
using System.Collections.Generic;

namespace _98_361_code_test
{
    class Program
    {
        public static int i = 1;
        static void Main(string[] args)
        {
            foreach (var item in Ranks(true))
            {
                Console.WriteLine("Ranks:" + item);
            }

            Console.WriteLine("i%2:"+ i % 2);
            
        }

        static IEnumerable<string> Ranks(bool a)
        {
            yield return "John";

            if (a)
            {
                yield break;
                
            }
            yield return "Chris";
        }
    }
}
