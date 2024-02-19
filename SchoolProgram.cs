using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_AggregationAndContainment_Hafsa
{
    internal class SchoolProgram
    {
        //feilds
        public string _className;
        public string _classNumber;
        public string _roomNumber;
        public Instructor _instructor;
        public List<Student> _classRoster;

        //constructor and properties
        public string ClassName { get; set; }
        public string ClassNumber { get; set; }
        public string RoomNumber { get; set; }
        public Instructor Instructor { get; set; }
        public List<Student> ClassRoster { get; }


        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            _instructor = instructor;
            _classRoster = new List<Student>();
        }

        //methods
        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
            _classRoster.Add(student);
        }

        public override string ToString()
        {
            return $"{_className} {_classNumber} - {_roomNumber} - {_instructor} - Number of Students: {_classRoster.Count}";
        }


    }
}
