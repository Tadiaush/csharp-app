using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LaboraiApp01
{
    class source
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

            //Sorting the students
            List<Student> bad = new List<Student>();
            List<Student> good = new List<Student>();
            double sortingGrade = 0;

            //Path for both OS: Windows or OSX
            string filesPath = @"D:\Projects\CSharp\Laboratorinis2\LaboraiApp01\LaboraiApp01\students\";

            PrintingOutput printout = new PrintingOutput();
            Student gradesCalc = new Student();

            //Choise to enter the input data
            Console.WriteLine("Input choice" + "\n" + "C - through Terminal" + " ; F - input file");
            caseSwitch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (caseSwitch)
            {
                case 'c':
                    Console.WriteLine("How many students? ");
                    count = Convert.ToInt16(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Input data must be in this format:"
                                        + "\n"
                                        + "First name Last name");
                        string row = Console.ReadLine();
                        string[] word = row.Split(new char[0]);
                        studfname = word[0];
                        studlname = word[1];

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
                        Console.WriteLine("Insert student final exam grade:");
                        examresult = Convert.ToInt16(Console.ReadLine());

                        stud.Add(new Student(i, studfname, studlname, allhomeworkgrades, examresult));
                    }

                    printout.ResultLines();
                    printout.StudentGrades(stud);


                    break;

                case 'f':
                    string path = @"D:\Projects\CSharp\Laboratorinis2\LaboraiApp01\LaboraiApp01\students\kursiokai.txt";

                    int index = 0;

                    try
                    {
                        using (StreamReader studFile = new StreamReader(path))
                        {
                            while (!studFile.EndOfStream)
                            {
                                if (index == 0)
                                {
                                    studFile.ReadLine();
                                }
                                string row = studFile.ReadLine();
                                if (row == " ")
                                {
                                    break;
                                }
                                string[] word = row.Split(new char[0]);

                                studfname = word[0];
                                studlname = word[1];
                                allhomeworkgrades.Clear();

                                for (int i = 2; i < 7; i++)
                                {
                                    allhomeworkgrades.Add(Convert.ToInt16(word[i]));
                                }
                                examresult = Convert.ToInt16(word[7]);

                                stud.Add(new Student(index, studfname, studlname, allhomeworkgrades, examresult));
                                index++;

                                sortingGrade = gradesCalc.GradesCalculationMed(examresult, allhomeworkgrades.ToArray());
                                if (sortingGrade < 5.0)
                                {
                                    bad.Add(new Student(index, studfname, studlname, allhomeworkgrades, examresult));
                                }
                                else if (sortingGrade >= 5.0)
                                {
                                    good.Add(new Student(index, studfname, studlname, allhomeworkgrades, examresult));
                                }
                            }
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("File has bad format ", ex);
                    }
                    printout.ResultLines();
                    printout.StudentGrades(stud);
                    foreach (var st in bad)
                    {
                        printout.WritingToFile(1, st);
                    }
                    foreach (var st in good)
                    {
                        printout.WritingToFile(2, st);
                    }

                    break;
            }
        }
    }
}
