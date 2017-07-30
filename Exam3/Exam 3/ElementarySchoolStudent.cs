using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    class ElementarySchoolStudent : Student, IMathClass
    {
        // Contructor
        public ElementarySchoolStudent(string name, string last, string id) : base(name, last, id)
        {
        }

        // Class mathod override
        public override string ImportantThing()
        {
            return "Farm field trip!";
        }

        // Interface method
        public string Math()
        {
            return "Basic Math.";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + ". I am an Elementary School student. I will go on a " + this.ImportantThing() + " I am learning " + this.Math();
        }
    }
}
