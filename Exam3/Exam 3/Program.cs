using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize array
            Student[] students = { new ElementarySchoolStudent("John", "Doe", "741852"),
                                   new MiddleSchoolStudent("Jane", "Singleton", "852963"),
                                   new HighSchoolStudent("Jim", "Bim", "123789"),
                                   new CollegeStudent("Joel", "Milligan", "743842")
                                 };

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }

            // Wait for user exit
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
