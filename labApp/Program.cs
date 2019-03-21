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
            int s_namuDarbas=0, s_egzRezul, ndPaz;
            double s_galPaz, s_ndMedian;


            Console.WriteLine("Iveskite studento varda ir pavarde");
            s_vardas = Console.ReadLine();
            s_pav = Console.ReadLine();
            
            List<int> ndPazymiai = new List<int>();
            Console.WriteLine("Namu darbai:" + "\n" + "Namu darbu skaicius" + "\n");
            ndSkaicius = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Namu darbu pazymiai:");
            for (int i=0;i<ndSkaicius;i++){
                ndPaz = Convert.ToInt16(Console.ReadLine());
                ndPazymiai.Add(ndPaz);
                s_namuDarbas += ndPaz;
            };

            Console.WriteLine("Iveskite studento egzamino rezultata:");
            s_egzRezul = Convert.ToInt16(Console.ReadLine());

            //Calculate the main grade.
            s_galPaz = (0.3 * (s_namuDarbas / ndPazymiai.Count)) + (0.7 * s_egzRezul);
            //s_galPaz = (0.3 * s_namuDarbas) + (0.7 * s_egzRezul);
            s_ndMedian = GetMedian(Convert.ToDouble(ndPazymiai));

            
            //Formating the line, so everything could in a columns. 
            Console.WriteLine("Vardas".PadRight(15,' ') + 
                              "Pavarde".PadRight(15,' ') +
                              "Galutinis(Vid.)".PadRight(10,' '));
            //Creating one line full of dash
            for (int i=0;i<45;i++){
                Console.Write("-");
            }
            Console.WriteLine();
            //Padding the values to the right with enough of space. 
            Console.WriteLine(s_vardas.PadRight(15,' ') +
                              s_pav.PadRight(15,' ') +
                              s_galPaz.ToString().PadRight(10,' '));
        }
        public static double GetMedian (List<int> sarasas) {

        int numberCount = sarasas.Count;
        int halfCount = numberCount/2;
        sarasas.Sort();
        
        double median;

        if ((numberCount % 2) == 0) {
            median = ((sarasas.Find(numberCount)))
        }
        
        
    }
    }
}
