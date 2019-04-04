using System;
using System.Collections.Generic;

namespace labApp
{
    public class Student
    {
        int id;
        string studFName;
        string studLName;
        int studEgz;
        List<int> studND = new List<int>();


        public Student(int id, string studFName, string studLName, List<int> studND, int studEgz)
        {
            this.id = id;
            this.studFName = studFName;
            this.studLName = studLName;
            this.studND = studND;
            this.studEgz = studEgz;
        }
        public String PrintOut()
        {
            double median = GetMedian(this.studND.ToArray());
            double galPazymys = (0.3 * StuPaz(this.studND.ToArray())) + (0.7 * this.studEgz);

            /* return (studFName.PadRight(15, ' ') +
                    studLName.PadRight(15, ' ') +
                    galPazymys.ToString("0.00").PadRight(15, ' ') +
                    median.ToString("0.00").PadRight(10, ' ')
                    );*/

            //return (String.Format("(0,-15) (1,0) (2, 10) (3,20)", studFName, studLName, galPazymys, median));
            return ($"{studFName} {studLName} {galPazymys} {median}");
        }
        //The input is array of homework grades. 
        public double StuPaz(int[] pazymiai)
        {
            int sumPazymiai = 0;
            for (int i = 0; i < pazymiai.Length; i++)
            {
                //studND.Add(pazymiai[i]);

                sumPazymiai += pazymiai[i];
            }

            return sumPazymiai / pazymiai.Length;
        }
        //The inout is array of homework grades. 
        public static double GetMedian(int[] sarasas)
        {

            int size = sarasas.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sarasas[mid] : ((double)sarasas[mid] + (double)sarasas[mid - 1]) / 2;
            return median;

        }


    }
}