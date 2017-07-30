using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    class HighSchoolStudent : Student, IMathClass
    {
        // Contructor
        public HighSchoolStudent(string name, string last, string id) : base(name, last, id)
        {
        }

        // Class mathod override
        public override string ImportantThing()
        {
            return "SAT exam.";
        }

        // Interface method
        public string Math()
        {
            return "Basic Algebra.";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + ". I am a High School student. I will have a " + this.ImportantThing() + " I am learning " + this.Math();
        }
    }
}
