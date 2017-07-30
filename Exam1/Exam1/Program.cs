using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Each new 'section' of dialog will start with a \n character 
             * to make the output more readable for the user.
             */

            // Initalize Person class
            Person newPerson = new Person();

            // Display output to the user
            Console.WriteLine("Welcome to the retirement calculator!\n");
            Console.WriteLine("To start off, who do we have the pleasure of speaking with today?"); // Ask for name

            newPerson.Name = Console.ReadLine(); // Collect user input

            //Thank person
            Console.WriteLine("\nIt's great to have you with us {0}!", newPerson.Name);
            Console.WriteLine("How old are you?"); // Ask for age

            // Collect user input and convert it to an Int from a String
            newPerson.Age = Convert.ToInt16( Console.ReadLine() );

            // Calculate years left to work and show output to the user
            Console.WriteLine("\nThank you!");
            Console.WriteLine("By our calculations, you will work : {0} more years until you retire.", newPerson.YTK());

            // Pause app until user presses another key
            Console.WriteLine("\nPress any key to exit.");
            Console.Read();
        }
    }
}
