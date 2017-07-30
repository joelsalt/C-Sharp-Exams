using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    class CollegeStudent : Student, IMathClass
    {
        // Contructor
        public CollegeStudent(string name, string last, string id) : base(name, last, id)
        {

        }

        // Class mathod override
        public override string ImportantThing()
        {
            return "Major.";
        }

        // Interface method
        public string Math()
        {
            return "Advanced Algebra.";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + ". I am a High School student. I have a " + this.ImportantThing() + " I am learning " + this.Math();
        }
    }
}
