using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLAB
{
    class Staff: Person
    {
        public string School { get; set; }
        public double Pay { get; set;}

        public Staff ()
        {

        }
        public Staff (string name) : base(name)
        {

        }
        public Staff (string school, double pay)
        {
            this.School = school;
            this.Pay = pay;
        }
        public override void ToString()
        {
            base.ToString();
            Console.WriteLine(School, Pay);
        }

    }
}
