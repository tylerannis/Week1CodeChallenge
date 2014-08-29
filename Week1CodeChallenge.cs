using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            for (int i = 0; i <= 20; i = i + 1)
            {
                FizzBuzz(i);
            }
            for (int j = 92; j >= 72; j = j - 1)
            {
                FizzBuzz(j);
            }
            TextStats("The Doctor: Who's she? Karzan Sardick: Nobody important. The Doctor: Nobody important? Blimey, that's amazing. You know that in nine hundred years of time and space and I've never met anybody who wasn't important before.");

            Yoadizer("I like Code.");

            for (int i = 1; i <= 25; i= i + 2)
            {
                IsPrime(i);
            }

            Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        //3
        static void Yoadizer(string text)
        {           
           List<string> list = text.Split(' ').ToList();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
            
        }
       //4
        static void TextStats(string input)
        {
            Console.WriteLine("Number of letters " + input.Length);

            List<string> words = input.Split(' ').ToList();
            Console.WriteLine("Number of words " + words.Count());
            
            int vowelCounter = 0;
            int conCounter = 0;
            int specialCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {

                if ("aeiou".Contains(input[i]))
                {
                    vowelCounter = vowelCounter + 1;
                }
                else if ("qwrtypsdfghjklzxcvbnm".Contains(input[i]))
                {
                    conCounter = conCounter + 1;
                }
                else
                {
                    specialCounter = specialCounter + 1;
                }
            }
            Console.WriteLine(vowelCounter);
            Console.WriteLine(conCounter);
            Console.WriteLine(specialCounter);
        }
        //5
        static void IsPrime(int number)
        {
            bool isPrime1 = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime1 = false;
                }              
            }
            if (isPrime1)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        //6
        static void DashInsert(int number)
        {

        }
    }
}
