using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            int len = inputString.Length;
            Console.WriteLine("All substrings for given string are : ");             
            for (int i = 0; i < len; i++)
            {                
                for (int j = 0; j < len - i; j++)
                {
                    Console.Write(inputString.Substring(i, j + 1) + " ");
                }
            }
            Console.ReadKey();
        }
    }
    }