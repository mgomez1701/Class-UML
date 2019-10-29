using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLAB
{
    class Student: Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }


        public Student()
        {

        }
        public Student(string name) : base(name)
        {

        }
        public Student (string program, int year, double fee)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public override void ToString()
        {
            base.ToString();
           
        }

    }
}
