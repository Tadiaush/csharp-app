using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboraiApp01
{
    public class PrintingOutput
    {
        public void ResultLines()
        {
            Console.WriteLine("{0,0:C}{1,15:C}{2,25:C}{3,2:C}{4,11:C}",
                               "Vardas", "Pavarde", "Galutinis(vid.)", "/", "Galutinis(med.)");
            //Creating one line full of dash 
            for (int i = 0; i < 61; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public void StudentGrades(Queue<Student> student)
        {
            foreach (var stud in student)
            {
                stud.Output();
            }
            //Console.ReadLine();
        }

        public void WritingToFile(int k, Student st)
        {
            string folderpath = @"D:\Projects\CSharp\Laboratorinis2\LaboraiApp01\LaboraiApp01\students\";
            if (k == 1)
            {
                string fullpath = Path.Combine(folderpath, "vargsiukai.txt");
                using (StreamWriter outputFile = new StreamWriter(fullpath, true))
                {
                    outputFile.WriteLine(st.OutputToFile());
                }
            }
            else if (k == 2)
            {
                string fullpath = Path.Combine(folderpath, "kietiakai.txt");
                using (StreamWriter outputFile = new StreamWriter(fullpath, true))
                {
                    outputFile.WriteLine(st.OutputToFile());
                }
            }

        }



    }
}
