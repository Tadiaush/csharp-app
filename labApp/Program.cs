using System;

namespace labApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite studento varda ir pavarde");
            //string s_vardas = Convert.ToString(Console.Read());
            //string s_pav = Convert.ToString(Console.Read());
            string s_vardas = Console.ReadLine();
            string s_pav = Console.ReadLine();
            //Console.ReadLine();
            Console.WriteLine("Iveskite studento namu darbu ir egzamino rezultata:");
            double s_namuDarbas = Convert.ToDouble(Console.ReadLine());
            double s_egzRezul = Convert.ToDouble(Console.ReadLine());
            //Console.ReadLine();

            Console.WriteLine(s_vardas + " " + s_pav);

            double s_galPaz; 
            s_galPaz = (0.3 * s_namuDarbas) + (0.7 * s_egzRezul);
            /*Console.WriteLine("Vardas" + "\t"
                              + "Pavarde" + "\t"
                              + "Galutinis(Vid).");*/
            Console.WriteLine("{0,-20}{1:-20}{2,-20}", "Vardas", "Pavarde","Galutinis(Vid.)");
            for (int i=0;i<41;i++){
                Console.Write("-");
            }
            Console.WriteLine();
            //Console.WriteLine(s_vardas + "\t" + s_pav + "\t" + s_galPaz);
            Console.WriteLine("{0,-20}{1:-20}{2,-20}",s_vardas, s_pav, s_galPaz);
        }
    }
}
