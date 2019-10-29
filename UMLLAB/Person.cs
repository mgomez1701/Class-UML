using System;
using System.Collections.Generic;
using System.Text;

namespace UMLLAB
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        
        public Person ()
        {

        }
        public Person (string name)
        {
            Name = name;
        }
        public Person (string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public virtual void ToString()
        {
           
        }
    }
}
