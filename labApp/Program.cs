﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace labApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite kurio budu norite suvesti:");
            Console.WriteLine("C - per terminala, F - programa nuskaito pazymius is failo");
            char caseSwitch = Convert.ToChar(Console.ReadLine());
            //char caseSwitch = 'f';


            Random rnd = new Random();
            List<Student> stud = new List<Student>();
            int a = 1;

            List<int> visiPaz = new List<int>();
            string stuVardas, stuPavarde;
            int kiekis, kiekisPazymiu;
            string pazymys;
            int egzRezul;

            List<string> vargsiukai = new List<string>();
            List<string> kietiakai = new List<string>();

            switch (caseSwitch)
            {
                case 'c':
                    Console.WriteLine("Kiek studentu ivesite");
                    kiekis = Convert.ToInt16(Console.ReadLine());
                    //int kiekis = 3;

                    for (int i = 0; i < kiekis; i++)
                    {
                        Console.WriteLine("Vardas:");
                        stuVardas = Console.ReadLine();
                        //string stuVardas = "ASasd";
                        Console.WriteLine("Pavarde:");
                        stuPavarde = Console.ReadLine();
                        //string stuPavarde = "Asdasdasd";
                        Console.WriteLine("Kiek ivesite pazymiu?");
                        kiekisPazymiu = Convert.ToInt16(Console.ReadLine());
                        //int kiekisPazymiu = 2;
                        visiPaz.Clear();
                        for (int j = 0; j < kiekisPazymiu; j++)
                        {
                            pazymys = Console.ReadLine();
                            //string pazymys = " ";
                            if (pazymys != " ")
                            {
                                visiPaz.Add(Convert.ToInt16(pazymys));
                            }
                            else
                            {
                                visiPaz.Add(rnd.Next(1, 10));
                            }
                        }
                        Console.WriteLine("Iveskite studento egzamino rezultata");
                        egzRezul = Convert.ToInt16(Console.ReadLine());
                        //int egzRezul = 10;
                        //
                        stud.Add(new Student(i, stuVardas, stuPavarde, visiPaz, egzRezul));
                    }
                    //For up end. 

                    break;
                case 'f':
                    string path = @"/Users/tadas/programming/C#/csharp-app/labApp/kursiokai.txt";
                    string[] text = new string[7];
                    int index = 0;
                    //try
                    //{
                        using (StreamReader studFile = new StreamReader(path))
                        {
                            while (!studFile.EndOfStream)
                            {
                                if (index == 0)
                                {
                                    studFile.ReadLine();
                                }
                                string eilute = studFile.ReadLine();
                                text = eilute.Split(" ");
                                stuVardas = text[0];
                                stuPavarde = text[1];
                                visiPaz.Clear();
                                for (int j = 2; j < 7; j++)
                                {
                                    visiPaz.Add(Convert.ToInt16(text[j]));
                                }
                                egzRezul = Convert.ToInt16(text[7]);
                                //
                                stud.Add(new Student(index, stuVardas, stuPavarde, visiPaz, egzRezul));
                                index++;
                            }
                        }
                        break;
                    //}
                    /* catch (FormatException ex)
                    {
                        Console.WriteLine("Failas netinkamai suformatuotas");
                        break;
                    } */

            }
            ResultLines(a);
            //a++;
            foreach (var item in stud)
            {
                Console.WriteLine(item.PrintOut() + '\n');
                //if (item.medianGet() < 5.0){
                //    
                //}

            }


        }
        public static void ResultLines(int a)
        {
            if (a == 1)
            {
                //Formating the line, so everything could in a columns. 
                Console.WriteLine("Vardas".PadRight(15, ' ') +
                                  "Pavarde".PadRight(15, ' ') +
                                  "Galutinis(Vid.)".PadRight(10, ' ') +
                                  "/".PadRight(5, ' ') +
                                  "Galutinis (Med.)".PadRight(10, ' '));
                //Creating one line full of dash
                for (int i = 0; i < 61; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}
