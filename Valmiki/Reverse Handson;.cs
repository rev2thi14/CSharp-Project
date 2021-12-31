using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("enter your string");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while(Length>=0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine(reverse);
            Console.ReadKey();
                }
            }
}