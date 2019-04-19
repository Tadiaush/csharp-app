using System;
using labApp;

namespace labApp
{
    public class PrintingOutput
    {
        public static void ResultLines()
        {
            //Formating the line, so everything could in a columns. 
            Console.WriteLine("Vardas".PadRight(15, ' ') +
                              "Pavarde".PadRight(15, ' ') +
                              "Galutinis(Vid.)".PadRight(10, ' ') +
                              //"/".PadRight(5, ' ') +
                              "Galutinis (Med.)".PadRight(10, ' '));
            //Creating one line full of dash
            for (int i = 0; i < 61; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }

        public static void StudentGrades(List<Student> student)
        {
            foreach (var stud in student)
            {
                stud.Output();
            }
        }
    }
}