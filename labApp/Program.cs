using System;
using System.Collections.Generic;

namespace labApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadLine();

            Console.WriteLine("Namu darbu pazymiai:");
            for (int i = 0; i < ndSkaicius; i++)
            {
                ndPaz = Convert.ToInt16(Console.ReadLine());
                ndPazymiai.Add(ndPaz);
                s_namuDarbas += ndPaz;
            };

            Console.WriteLine("Iveskite studento egzamino rezultata:");
            s_egzRezul = Convert.ToInt16(Console.ReadLine());

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
