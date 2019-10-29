using System;
using System.Collections.Generic;

namespace UMLLAB
{
    class Program
    {

        static void Main(string[] args)
        {

            Student student1 = new Student("Ben");
            Student student2 = new Student("Glenn");
            Student student3 = new Student("Doug");

            Staff staff1 = new Staff("Mr. Rivas");
            Staff staff2 = new Staff("Mrs. Rubio");

            List<Person> personList = new List<Person> { student1, student2, student3, staff1, staff2 };
            Console.WriteLine(personList);
        }
    }
}
