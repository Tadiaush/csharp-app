using System;
using System.Collections.Generic;
using System.IO;

namespace labApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite kurio budu norite suvesti:");
            Console.WriteLine("C - per terminala, F - programa nuskaito pazymius is failo");
            char caseSwitch = Convert.ToChar(Console.ReadLine());

            switch (caseSwitch)
            {
                case 'C':
                    string s_vardas, s_pav;
                    int ndSkaicius;
                    int s_namuDarbas = 0, s_egzRezul, ndPaz;
                    double s_galPaz, s_ndMedian;
                    List<int> ndPazymiai = new List<int>();

                    Console.WriteLine("Iveskite studento varda ir pavarde");
                    s_vardas = Console.ReadLine();
                    s_pav = Console.ReadLine();


                    Console.WriteLine("Namu darbai:" + "\n" + "Namu darbu skaicius" + "\n");
                    ndSkaicius = Convert.ToInt16(Console.ReadLine());

                    ConsoleKeyInfo keyInfo;
                    Random rnd = new Random();

                    Console.WriteLine("Namu darbu pazymiai:");
                    for (int i = 0; i < ndSkaicius; i++)
                    {
                        keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            ndPaz = rnd.Next(1, 10);
                            ndPazymiai.Add(ndPaz);
                        }
                        else
                        {
                            ndPaz = Convert.ToInt16(Console.ReadLine());
                            ndPazymiai.Add(ndPaz);
                            s_namuDarbas += ndPaz;
                        };
                    };

                    Console.WriteLine("Iveskite studento egzamino rezultata:");
                    keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        s_egzRezul = rnd.Next(1, 10);
                    }
                    else
                    {
                        s_egzRezul = Convert.ToInt16(Console.ReadLine());
                    };


                    //Calculate the main grade.
                    s_galPaz = (0.3 * (s_namuDarbas / ndPazymiai.Count)) + (0.7 * s_egzRezul);

                    int[] pazMasyv = ndPazymiai.ToArray();
                    s_ndMedian = GetMedian(pazMasyv);

                    //Formating the line, so everything could in a columns. 
                    Console.WriteLine("Vardas".PadRight(15, ' ') +
                                      "Pavarde".PadRight(15, ' ') +
                                      "Galutinis(Vid.)".PadRight(10, ' ') +
                                      "/".PadRight(2, ' ') +
                                      "Galutinis (Med.)".PadRight(10, ' '));
                    //Creating one line full of dash
                    for (int i = 0; i < 61; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    //Padding the values to the right with enough of space. 
                    Console.WriteLine(s_vardas.PadRight(15, ' ') +
                                      s_pav.PadRight(15, ' ') +
                                      s_galPaz.ToString("0.00").PadRight(10, ' ') +
                                      s_ndMedian.ToString("0.00").PadRight(12, ' '));
                    break;
                case 'F':
                    string path = @"/Users/tadas/programming/C#/csharp-app/labApp/kursiokai.txt";
                    
                    Student[] myStudents = new Student[10];
                    List<int> studND = new List<int>();

                    //Formating the line, so everything could in a columns. 
                    Console.WriteLine("Vardas".PadRight(15, ' ') +
                                      "Pavarde".PadRight(15, ' ') +
                                      "Galutinis(Vid.)".PadRight(10, ' ') +
                                      "/".PadRight(2, ' ') +
                                      "Galutinis (Med.)".PadRight(10, ' '));
                    //Creating one line full of dash
                    for (int i = 0; i < 61; i++)
                    {
                        Console.Write("-");
                    }
                    //Console.WriteLine();

                    using (StreamReader pazFile = new StreamReader(path))
                    {

                        int index = 0;
                        string header = pazFile.ReadLine();
                        while (!pazFile.EndOfStream)
                        {
                            Student stud = new Student();
                            string[] eil = Console.ReadLine().Split();
                            stud.StuFName = eil[0];
                            stud.StuLName = eil[1];
                            stud.StuND1 = int.Parse(eil[2]);
                            stud.StuND2 = int.Parse(eil[3]);
                            stud.StuND3 = int.Parse(eil[4]);
                            stud.StuND4 = int.Parse(eil[5]);
                            stud.StuND5 = int.Parse(eil[6]);
                            stud.StuEgz = int.Parse(eil[7]);
                            myStudents[index++] = stud;

                            int studSumND = stud.StuPaz();
                            if (!pazFile.EndOfStream)
                            {
                                studND.Add(studSumND);
                            };

                            //Calculate the main grade for each student
                            //foreach (int element in studND)
                            //{
                            s_galPaz = (0.3 * (studSumND / 5)) + (0.7 * stud.StuEgz);
                            //int[] ndArray = studND.ToArray();
                            s_ndMedian = GetMedian(studND.ToArray());
                            //Padding the values to the right with enough of space. 
                            Console.WriteLine(stud.StuFName.PadRight(15, ' ') +
                                              stud.StuLName.PadRight(15, ' ') +
                                              s_galPaz.ToString("0.00").PadRight(10, ' ') +
                                              s_ndMedian.ToString("0.00").PadRight(12, ' '));
                            //}

                        }
                    }
                    break;
            }


        }
        public static double GetMedian(int[] sarasas)
        {

            int size = sarasas.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sarasas[mid] : ((double)sarasas[mid] + (double)sarasas[mid - 1]) / 2;
            return median;

        }
    }
}
