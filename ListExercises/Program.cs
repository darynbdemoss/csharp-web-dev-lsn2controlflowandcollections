using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> myNumbers = new List<int>();
            myNumbers.Add(3);
            myNumbers.Add(6);
            myNumbers.Add(23);
            myNumbers.Add(67);
            myNumbers.Add(68);
            myNumbers.Add(334);
            myNumbers.Add(336);
            myNumbers.Add(90);

            
            Console.WriteLine(evenSum(myNumbers));

            List<string> letters = new List<string>();
            letters.Add("daryn");
            letters.Add("darrryn");
            letters.Add("darryn");
            letters.Add("dyn");
            letters.Add("daasdryn");

            letterCounter(letters);

            Console.WriteLine("\nEnter a word length: ");
            int length = Int32.Parse(Console.ReadLine());

            wordLength(letters, length);

        }
        static int evenSum(List<int> numbers)
        {
            int even = 0;

            
            foreach (int number in numbers)
                if (number % 2 == 0)
                {
                    even += number;
                }

            return even;
        }
        static void letterCounter(List<string> words)
        {
            foreach (string word in words)
                if (word.Length == 5)
            {
                    Console.WriteLine(word);
            }


        }

        static void wordLength(List<string>words, int userLength)
        {
            foreach (string word in words)
                if (word.Length == userLength)
                {
                    Console.WriteLine(word);
                }
        }

    }
}
