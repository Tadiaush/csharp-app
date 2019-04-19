using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;


namespace labApp
{
    class LabMain
    {
        static void Main(string[] args)
        {
            //Global kintamieji:
            Random rnd = new Random();
            char caseSwitch;

            List<Student> stud = new List<Student>();
            List<int> allhomeworkgrades = new List<int>();
            string studfname, studlname, grade;
            int count, countgrades, examresult;

            PrintingOutput printout = new PrintingOutput();

            //Choise to enter the input data
            Console.WriteLine("Input choice" + "\n" + "C - through Terminal" + " ; F - input file");
            caseSwitch = Convert.ToChar(Console.ReadLine().ToLower());
            //caseSwitch = 'f';

            switch (caseSwitch)
            {
                case 'c':
                    Console.WriteLine("How many students? ");
                    count = Convert.ToInt16(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Input data must be in this format:"
                                        + "\n"
                                        + "First name; Last name; Grades (split by space), exam result");
                        var row = Console.ReadLine().Split(" ");
                        studfname = row[0];
                        studlname = row[1];

                        Console.WriteLine("How many grades does the student has?");
                        countgrades = Convert.ToInt16(Console.ReadLine());

                        for (int j = 0; j < countgrades; j++)
                        {
                            Console.WriteLine("Insert the grade: ");
                            grade = Console.ReadLine();

                            if (grade != " ")
                            {
                                allhomeworkgrades.Add(Convert.ToInt16(grade));
                            }
                            else
                            {
                                allhomeworkgrades.Add(rnd.Next(1, 10));
                            }
                        }
                        Console.WriteLine("Insert students final exam grade:");
                        examresult = Convert.ToInt16(Console.ReadLine());

                        stud.Add(new Student(i, studfname, studlname, allhomeworkgrades, examresult));
                    }
                    printout.ResultLines();
                    printout.StudentGrades(stud);

                    break;

                case 'f':
                    break;


            }




        }
    }
}
