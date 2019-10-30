using System;
using System.Collections.Generic;

namespace UMLLAB
{
    class Program
    {

        static void Main(string[] args)
        {

            Person student1 = new Student("Ben");
            Person student2 = new Student("Glenn");
            Person student3 = new Student("Doug");

            Person staff1 = new Staff("Mr. Rivas");
            Person staff2 = new Staff("Mrs. Rubio");


            List<Person>listAll = new List <Person>{student1,student2,student3,staff1,staff2};
            foreach(Person p in listAll)
            {
                Console.WriteLine(p.Name);
            }

         
            
           
            
        }
    }
}
