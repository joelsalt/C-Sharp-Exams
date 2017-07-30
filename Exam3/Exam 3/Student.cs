using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
     abstract class Student
    {
        // Initialize variables
        private string firstName, lastName, studentID;

        // Constructor
        public Student(string name, string last, string id)
        {
            FirstName = name;
            LastName = last;
            StudentID = id;
        }

        // Create readonly properties
        public string FirstName { get; }
        public string LastName { get; }
        public string StudentID { get; }

        // Abstract method
        public abstract string ImportantThing();
    }
}
