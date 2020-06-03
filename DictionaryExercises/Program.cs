using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            string newStudent;

            Console.WriteLine("Enter your students names and IDs(or Enter to Finish) :");

            do
            {
                Console.Write("Student name: ");
                newStudent = Console.ReadLine();

                if (newStudent != "")
                {
                    Console.WriteLine("ID Number: ");
                    int newID = Int32.Parse(Console.ReadLine());

                    students.Add(newID, newStudent);
                }

            } while (newStudent != "");

            Console.WriteLine("\nThe Class List: ");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Value}'s ID: {student.Key}");
            }
        }
    }
}
