using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create course objects
            Course course1 = new Course("CTS1851", "Internet Web Foundation");
            Course course2 = new Course("CGS2820", "Web Programming");
            Course course3 = new Course("CGS2821", "Advanced Web Programming");
            Course course4 = new Course("COP2361", "C# Programming");

            // Create dictionary
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            // Add elements to the dictionary
            courses.Add(course1.ID, course1);
            courses.Add(course2.ID, course2);
            courses.Add(course3.ID, course3);
            courses.Add(course4.ID, course4);

            int count = 1;

            // For loop to print values
            foreach (KeyValuePair<string, Course> c in courses) {
                Console.WriteLine("Course {0} ID is: {1}, course name is {2}.", count, c.Key, c.Value.Name);

                // Increase the count
                count++;
            }

            // Wait for user exit
            Console.WriteLine("\nPress any key to exit...");
            Console.Read();

        }
    }
}
