using System;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool Double_check(string strng)
        {
            strng = strng.ToLower();
            for (int i=1;i<strng.Length;i++)
            {
                char last = strng[i-1];
                char current = strng[i];
                if (last == current)
                {
                    return true;
                }
              
            }

            return false;

        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();
                Console.WriteLine(Double_check(input));
                Console.WriteLine("\n");
            }
        }
    }
}
