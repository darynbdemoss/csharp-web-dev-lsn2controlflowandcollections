using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] words = phrase.Split(", ");

            foreach (var word in words)


            {
                //Console.WriteLine($"<{word}>");
                //Console.WriteLine(string.Join(" ", words));
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
