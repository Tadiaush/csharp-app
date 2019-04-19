using System;
//using System.Collections.Generic;

namespace labApp
{
    class Calculation
    {
        public double GetFinal(string choice, int exam, int[] hwgrades)
        {
            // The option to choice how to calculate final grade. With Median or with average
            if (choice == 'avg')
            {
                double finalgradeave = (0.3 * GetHomework(hwgrades)) + (0.7 * exam);
                return finalgradeave;
            }
            else if(choice == 'med')
            {
                double finalgrademed = (0.3 * GetMedian(hwgrades)) + (0.7 * exam);
                return finalgrademed;
            }

        }
        public double GetHomework(int[] grades)
        {
            try
            {
                int fullamount = 0;
                foreach (var grade in grades)
                {
                    fullamount += grade;
                }
                double average = fullamount / grades.Length;
                return average;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Not possible to divide the grades out of 0");
                return 0;
            }
        }

        public static double GetMedian(int[] list)
        {
            int size = list.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)list[mid] : ((double)list[mid] + (double)list[mid - 1]) / 2;
            return median;
        }
    }
}