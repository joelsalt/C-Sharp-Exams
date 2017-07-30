using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Course
    {

        // Initialize variables
        private string CID, CName;

        // Class properties
        public string ID { get; set; }
        public string Name { get; set; }

        // Constructor
        public Course(string id, string name)
        {
            ID = id;
            Name = name;
        }

    }
}
