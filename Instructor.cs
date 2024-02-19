using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_AggregationAndContainment_Hafsa
{
    internal class Instructor
    {
        //feilds
        public string _firstName;
        public string _lastName;

        //constructor 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Instructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //method
        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }

    }
}
