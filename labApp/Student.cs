using System;
using System.Collections.Generic;

namespace labApp
{
    public class Student
    {
        int id { get; set; }
        string studFName { get; set; }
        string studLName { get; set; }
        int studEgz { get; set; }
        List<int> studND = new List<int>();

        public Student(int id, string studFName, string studLName, List<int> studND, int studEgz)
        {
            this.id = id;
            this.studFName = studFName;
            this.studLName = studLName;
            this.studND = studND;
            this.studEgz = studEgz;

        }
        public Student(){
            this.id = id;
            this.studFName = studFName;
            this.studLName = studLName;
            this.studND = studND;
            this.studEgz = studEgz;
        }

        public double GradesCalculationAvg(int exam, int[] grade){
            string choice = "avg";
            Calculation calc = new Calculation();
            double calcgradeavg= calc.GetFinal(choice, exam, grade);
            return calcgradeavg;
        }
        public double GradesCalculationMed(int exam, int[] grade){
            string choice = "med";
            Calculation calc = new Calculation();
            double calcgrademed = calc.GetFinal(choice, exam, grade;
            return calcgrademed;
        }

        public void Output(){
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}",
              this.studFName,
              this.studLName,
              GradesCalculationAvg(this.studEgz, this.studND.ToArray()),
              GradesCalculationMed(this.studEgz, this.studND.ToArray())
            );
        }




        // public double medianGet()
        // {
        //     return this.median;
        // }
        // public double galPazymysGet()
        // {
        //     return this.galPazymys;
        // }


        // public String PrintOut()
        // {
        //     this.median = GetMedian(this.studND.ToArray());
        //     this.galPazymys = (0.3 * StuPaz(this.studND.ToArray())) + (0.7 * this.studEgz);

        //     /* return (studFName.PadRight(15, ' ') +
        //             studLName.PadRight(15, ' ') +
        //             galPazymys.ToString("0.00").PadRight(15, ' ') +
        //             median.ToString("0.00").PadRight(10, ' ')
        //             );*/

        //     //return (String.Format("(0,-15) (1,0) (2, 10) (3,20)", studFName, studLName, galPazymys, median));
        //     return ($"{studFName} {studLName} {galPazymys} {median}");
        // }
        //The input is array of homework grades. 
        // public double StuPaz(int[] pazymiai)
        // {

        //     try
        //     {
        //         int vidurkis = 0, sumPazymiai = 0;
        //         for (int i = 0; i < pazymiai.Length; i++)
        //         {
        //             //studND.Add(pazymiai[i]);

        //             sumPazymiai += pazymiai[i];
        //         }
        //         vidurkis = sumPazymiai / pazymiai.Length;
        //         return vidurkis;

        //     }
        //     catch (DivideByZeroException ex)
        //     {
        //         //LogError(ex):
        //         Console.WriteLine("Negalima atlikti dalybos veiksmo is nulio");
        //         return 0;
        //     }


        // }
        //The inout is array of homework grades. 
        // public static double GetMedian(int[] sarasas)
        // {

        //     int size = sarasas.Length;
        //     int mid = size / 2;
        //     double median = (size % 2 != 0) ? (double)sarasas[mid] : ((double)sarasas[mid] + (double)sarasas[mid - 1]) / 2;
        //     return median;

        // }
    }
}