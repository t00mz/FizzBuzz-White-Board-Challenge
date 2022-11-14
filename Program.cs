using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz_White_Board_Challenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
           
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                FizzBuzz(i);
            }          
        }

        public static void FizzBuzz(int x)
        {
            if (x % 3 == 0 && x % 5 == 0) { Console.WriteLine("Fizzbuzz"); }
            
            else if (x % 3 == 0) { Console.WriteLine("Fizz"); }

            else if (x % 5 == 0) { Console.WriteLine("Buzz"); }

            else { Console.WriteLine("That number is not divisible by 3 or 5."); }
                  
        }
    }
}