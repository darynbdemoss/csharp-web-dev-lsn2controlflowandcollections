using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 3, 5, 8 };
            foreach (var item in arr)         


            {
                if (item % 2 != 0)
                    Console.Write(item);               
            }
            
        }
    }
}
