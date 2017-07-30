using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    class MiddleSchoolStudent : Student, IMathClass
    {
        // Contructor
        public MiddleSchoolStudent(string name, string last, string id) : base(name, last, id)
        {
            
        }

        // Class mathod override
        public override string ImportantThing()
        {
            return "Summer camp!";
        }

        // Interface method
        public string Math()
        {
            return "Geometry.";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + ". I am a Middle School student. I will go to a " + this.ImportantThing() + " I am learning " + this.Math();
        }
    }
}
