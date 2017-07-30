using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    class Quiz
    {
        static void Main(string[] args)
        {
            // Initialize variables
            int attemptCount = 2; // Count down from 2
            string answerOne;     // User input
            string answerTwo;     // User input

            // Set up questions
            Console.WriteLine("Welcome to your first exam. You have 2 attempts to pass with 100%.");

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            while (attemptCount > 0)
            {
                // Question 1
                Question1();

                answerOne = Console.ReadLine().ToUpper(); // Return uppercase

                // Question 2
                Question2();

                answerTwo = Console.ReadLine().ToUpper(); // Return uppercase

                attemptCount--; // Decrease amount of attempts left

                Console.Clear(); // Clear the console to display the results

                if (answerOne == "B" && answerTwo == "A")
                {
                    // Got it correct
                    Console.WriteLine("You got 100%! Good job!");
                    break;
                }
                else if (answerOne == "B" || answerTwo == "A")
                {
                    // Got one answer right
                    OneCorrect(attemptCount);
                }
                else
                {
                    // Got no answers right
                    NoneCorrect(attemptCount);
                }
            }

            // Program end
            Console.WriteLine("\nPress any button to exit...");
            Console.Read();
        }

        // public function section
        public static void Question1()
        {
            // Template for question 1
            Console.WriteLine("1. Where is  the capital of the state of Florida?");
            Console.WriteLine("   A. Orlando");
            Console.WriteLine("   B. Tallahassee");
            Console.WriteLine("   C. Miami");
            Console.WriteLine("   D. Tampa");

            Console.Write("\nAnswer: ");
        }

        public static void Question2()
        {
            // Template for question 2
            Console.WriteLine("\n2. Where is Walt Disney World Park located in Florida?");
            Console.WriteLine("   A. Orlando");
            Console.WriteLine("   B. Tallahassee");
            Console.WriteLine("   C. Miami");
            Console.WriteLine("   D. Tampa");

            Console.Write("\nAnswer: ");
        }

        public static void OneCorrect(int attemptCount)
        {
            // Template for the message when 50% of the answers were right
            Console.WriteLine("You got 50%");
            Console.WriteLine("Attempts left: {0}", attemptCount);
            Console.WriteLine("\n{0}", attemptCount == 0 ? "You are out of tries." : "Press Enter to try again...");

            if (attemptCount > 0)
            {
                Console.ReadLine(); // Wait for input
                Console.Clear();
            }
        }

        public static void NoneCorrect(int attemptCount)
        {
            // Template for the message when 0% of the answers were right
            Console.WriteLine("You got 0%");
            Console.WriteLine("Attempts left: {0}", attemptCount);
            Console.WriteLine("\n{0}", attemptCount == 0 ? "You are out of tries." : "Press Enter to try again...");
            
            if (attemptCount > 0)
            {
                Console.ReadLine(); // Wait for input
                Console.Clear();
            }
        }

        // End public function section
    }
}
