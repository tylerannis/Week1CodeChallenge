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
            
            //using a for loop you can call said function for a certain series of numbers
            for (int i = 0; i <= 20; i = i + 1)
            {
                FizzBuzz(i);
            }
            for (int j = 92; j >= 72; j = j - 1)
            {
                FizzBuzz(j);
            }
            //Calling textstats
            TextStats("The Doctor: Who's she? Karzan Sardick: Nobody important. The Doctor: Nobody important? Blimey, that's amazing. You know that in nine hundred years of time and space and I've never met anybody who wasn't important before.");
            //calling Yoadizer
            Yoadizer("I like Code.");
            //Calling IsPrime
            for (int i = 1; i <= 25; i= i + 2)
            {
                IsPrime(i);
            }
            //Calling DashInsert
            DashInsert(8675309);

            Console.ReadKey();
        }
        //2
        static void FizzBuzz(int number)
        {
            //seting parameters for when to print out what word
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
            //change text to a list spliting at every space
           List<string> list = text.Split(' ').ToList();
            //loop through each character in your list starting at the end.Count
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
            
        }
       //4
        static void TextStats(string input)
        {
            //number of letters concatenated with number of characters
            Console.WriteLine("Number of letters " + input.Length);
            //changing string to list and do the same as before but with .Count
            List<string> words = input.Split(' ').ToList();
            Console.WriteLine("Number of words " + words.Count());
            //create counter variables
            int vowelCounter = 0;
            int conCounter = 0;
            int specialCounter = 0;
            //create a loop for your string so it goes through the characters, set to end at .Length
            for (int i = 0; i < input.Length; i++)
            {
                //checking for vowels
                if ("aeiou".Contains(input[i]))
                {
                    vowelCounter = vowelCounter + 1;
                }
                    //checking for constinants
                else if ("qwrtypsdfghjklzxcvbnm".Contains(input[i]))
                {
                    conCounter = conCounter + 1;
                }
                    //checking everything else
                else
                {
                    specialCounter = specialCounter + 1;
                }
            }
            //print your counters to the console outside the orignial loop but inside your function
            Console.WriteLine(vowelCounter);
            Console.WriteLine(conCounter);
            Console.WriteLine(specialCounter);
        }
        //5
        static void IsPrime(int number)
        {
            //set new variable to true
            bool isPrime1 = true;
            //use loop to run through the data
            for (int i = 2; i < number; i++)
            {
                //use if statement to set loop to find prime numbers
                if (number % i == 0)
                {
                    //reset value of new var to false
                    isPrime1 = false;
                }              
            }
            //if false then print __ is a prime number
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
            //set your variables
            bool odd = false;
            string output = string.Empty;
            //make a conversion string
            string convert = number.ToString();
           //make a loop 
            for (int i = 0; i < convert.Length; i++)
            {
                //Make individual characters available to manipulate
                int sweet = int.Parse(convert[i].ToString());
                //set your parameters for odd
                if (sweet % 2 == 0 || sweet == 0)
                {
                    odd = false;
                }
                else
                {
                    odd = true;
                }
                //concatinate sweet and output
                output = output + sweet;
                //make your parameters for checking to add a dash
                if (sweet % 2 != 0 && odd && i != convert.Length-1 && int.Parse(convert[i+1].ToString()) != 0)
                {
                    output = output + "-";
                }

            }
            //print output to console
            Console.WriteLine(output);
        }
    }
}
