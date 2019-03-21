using System;

namespace labApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite studento varda ir pavarde");
            string s_vardas = Console.ReadLine();
            string s_pav = Console.ReadLine();
            
            Console.WriteLine("Iveskite studento namu darbu ir egzamino rezultata:");
            double s_namuDarbas = Convert.ToDouble(Console.ReadLine());
            double s_egzRezul = Convert.ToDouble(Console.ReadLine());
            //isivedame galutinio pazymo kintamaji ir skaiciuojame pagal pateikta formule. 
            double s_galPaz; 
            s_galPaz = (0.3 * s_namuDarbas) + (0.7 * s_egzRezul);
          
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
    }
}
