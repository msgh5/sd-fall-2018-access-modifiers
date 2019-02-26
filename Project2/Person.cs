using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Person
    {
        //Every code can access this property
        public string Name { get; set; }

        //Only Person or Derived classes can access this property
        protected string LastName { get; set; }

        //Only Person can access this property
        private int Age { get; set; }

        //Only codes inside this assembly (Project2) can access this property
        internal string Address { get; set; }

        public Person()
        {
            LastName = "Something";
        }
    }

    public class Student : Person
    {
        public Student()
        {
            LastName = "Something";
        }
    }

}
