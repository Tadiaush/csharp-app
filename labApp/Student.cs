using System;

namespace labApp
{
    public class Student
    {
        public string StuFName { get; set; }
        public string StuLName { get; set; }
        public int StuND1 { get; set; }
        public int StuND2 { get; set; }
        public int StuND3 { get; set; }
        public int StuND4 { get; set; }
        public int StuND5 { get; set; }
        public int StuEgz { get; set; }

        public void StudentG()
        {
            StuFName = "";
            StuLName = "";
            StuND1 = 0;
            StuND2 = 0;
            StuND3 = 0;
            StuND4 = 0;
            StuND5 = 0;
            StuEgz = 0;
        }

        public int StuPaz()
        {
            int sumPaz = this.StuND1 + this.StuND2 + this.StuND3 + this.StuND4 + this.StuND5;
            return sumPaz;
        }



    }
}