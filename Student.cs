using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_AggregationAndContainment_Hafsa
{
    internal class Student
    {
        //feilds
        public string _firstName;
        public string _lastName;
        public int _csiGrade;
        public int _genEdGrade;

        //constructor and properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CsiGrade { get; set; }
        public int GenEdGrade { get; set; } 

        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CsiGrade = csiGrade;
            GenEdGrade = genEdGrade;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} - CSI Grade {_csiGrade} - GenEd Grade {_genEdGrade}";
        }

    }
}
