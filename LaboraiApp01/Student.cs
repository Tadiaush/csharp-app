using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboraiApp01
{
    public class Student
    {
        int id { get; set; }
        string studFName { get; set; }
        string studLName { get; set; }
        List<int> studND = new List<int>();
        int studEgz { get; set; }

        public Student(int id, string studFName, string studLName, List<int> studND, int studEgz)
        {
            this.id = id;
            this.studFName = studFName;
            this.studLName = studLName;
            this.studND = studND;
            this.studEgz = studEgz;

        }
        public Student()
        {
            this.id = id;
            this.studFName = studFName;
            this.studLName = studLName;
            this.studND = studND;
            this.studEgz = studEgz;
        }

        public double GradesCalculationAvg(int exam, int[] grade)
        {
            string choice = "avg";
            Calculation calc = new Calculation();
            double calcgradeavg = calc.GetFinal(choice, exam, grade);
            return calcgradeavg;
        }
        public double GradesCalculationMed(int exam, int[] grade)
        {
            string choice = "med";
            Calculation calc = new Calculation();
            double calcgrademed = calc.GetFinal(choice, exam, grade);
            return calcgrademed;
        }


        public void Output()
        {
            Console.WriteLine("{0,0:C}{1,14:C}{2,28:N}{3,17:N}",
            //Console.WriteLine("{0,0:C}{1,15:C}{2,15:N}{3,15:N}",
              this.studFName,
              this.studLName,
              GradesCalculationAvg(this.studEgz, this.studND.ToArray()),
              GradesCalculationMed(this.studEgz, this.studND.ToArray())
            );
        }

        public String OutputToFile()
        {
            return ($"{this.studFName} {this.studLName} {GradesCalculationAvg(this.studEgz, this.studND.ToArray())} {GradesCalculationMed(this.studEgz, this.studND.ToArray())}");
        }
    }
}
