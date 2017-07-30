using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Person //This class will represent a persons age, name, and years left to work
    {
        private string name; //initialize the name variable

        public string Name // Make the getter/setter method
        {
            get
            {
                return name; // Return the vairable
            }
            set
            {
                name = value; // Set the vairable equal to 'value'
            }
        }

        private int age; //initialize the age variable

        public int Age // Make the getter/setter method
        {
            get
            {
                return age; // Return the vairable
            }
            set
            {
                age = value; // Set the vairable equal to 'value'
            }
        }

        private int yearsToWork; //initialize the yearsToWork variable

        public int YearsToWork // Make the getter/setter method
        {
            get
            {
                return yearsToWork; // Return the vairable
            }
            set
            {
                yearsToWork = value; // Set the vairable equal to 'value'
            }
        }

        public int YTK() //Public method that sets the years left to work and returns it
        {
            YearsToWork = 65 - Age; // YTW is the age of retirement minus their current age

            return YearsToWork; // Return the vairable
        }
    }
}
