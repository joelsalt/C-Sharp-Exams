using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            int count = 0;
            string response;
            string[,] items = new string[100, 4];
            string buffer = "             "; // 13 spaces
            string tempBuffer;
            decimal subtotal = 0;
            decimal taxVar = 0.065m;
            decimal tax;
            decimal total;

            // Regex string expressions
            string itemExpression = @"^[0-9a-zA-Z\s\(\)\&\.\-_\+]{2,15}$";
            string priceExpression = @"^[0-9\.]{1,7}$";
            string countExpression = @"^[0-9]$";

            Console.WriteLine("Welcome to our shop!");

            do
            {
                // Get the item user is trying to buy
                Console.WriteLine("What is your {0} item: (Ex: Banana, Pasta, Soap), or type '0' to stop shopping", (count == 0 ? "first" : "next"));
                items[count, 0] = Console.ReadLine();
                response = items[count, 0];
                if (items[count, 0] == "0")
                {
                    Console.Clear();
                    break;
                }

                // Check user input
                while (!(Regex.Match(items[count, 0], itemExpression).Success))
                {
                    Console.WriteLine("Incorrect entry, please use numbers, letters, or these symbols: '()&-_+.'");
                    Console.WriteLine("What is your {0} item: (Ex: Banana, Pasta, Soap)");
                    items[count, 0] = Console.ReadLine();
                }

                // Get the item's price
                Console.WriteLine("\nWhat is the price of your item?");
                Console.Write("$");
                items[count, 1] = Console.ReadLine();

                // Check user input
                while (!(Regex.Match(items[count, 1], priceExpression).Success))
                {
                    Console.WriteLine("Incorrect entry, please use numbers and periods in a currency format");
                    Console.WriteLine("What is the price of your item?");
                    Console.Write("$");
                    items[count, 1] = Console.ReadLine();
                }

                // Get the number of items
                Console.WriteLine("\nHow many are you buying?");
                items[count, 2] = Console.ReadLine();

                // Check user input
                while (!(Regex.Match(items[count, 2], countExpression).Success))
                {
                    Console.WriteLine("Incorrect entry, please use a number from 0-9");
                    Console.WriteLine("How many are you buying?");
                    items[count, 2] = Console.ReadLine();
                }

                count++; // Increase count

                Console.Clear(); // Reset the screen

            } while (response != "0");

            // Set up the receipt
            Console.WriteLine("Here is your Receipt:\n");
            Console.WriteLine("+--------------+--------------+--------------+--------------+");
            Console.WriteLine("|     Name     |    Price     |   Quantity   |   Subtotal   |");
            Console.WriteLine("+--------------+--------------+--------------+--------------+");

            // Nested for loop to create the Receipt
            for (int i = 0; i < count; i++)
            {
                // Set the subtotal of the items
                items[i, 3] = Convert.ToString(Convert.ToDecimal(items[i, 1]) * Convert.ToDecimal(items[i, 2]));

                for (int j = 0; j < 4; j++)
                {
                    tempBuffer = buffer; // Reset the buffer string for the spacing between items

                    // Add a '$' to prices
                    if (j == 1 || j == 3)
                    {
                        // Remove the extra spaces from the buffer to 'size' it. Add one to
                        // account for the $ symbol
                        Console.Write("| $" + items[i, j] + tempBuffer.Remove(0, items[i, j].Length + 1));
                    }
                    else // Print the variable
                    {
                        // Remove the extra spaces from the buffer to 'size' it. 
                        Console.Write("| " + items[i, j] + tempBuffer.Remove(0, items[i, j].Length));
                    }
                }

                // Add to the subtotal
                subtotal += Convert.ToDecimal(items[i, 3]);

                // Move to the next line
                Console.WriteLine("|");
                Console.WriteLine("+--------------+--------------+--------------+--------------+");
            }

            Console.WriteLine("| Final Sale Price                                          |");
            Console.WriteLine("+-----------------------------------------------------------+");

            tempBuffer = buffer; // Reset the buffer string for the spacing between items

            // Show the subtotal to the customer
            Console.Write("| SubTotal:                                  | $" + subtotal + tempBuffer.Remove(0, Convert.ToString(subtotal, CultureInfo.InvariantCulture).Length + 1));
            Console.WriteLine("|");

            tempBuffer = buffer; // Reset the buffer string for the spacing between items

            // Calculate tax
            tax = subtotal * taxVar;

            // Show the tax to the customer
            Console.Write("| Tax:                                       | $" + tax + tempBuffer.Remove(0, Convert.ToString(tax, CultureInfo.InvariantCulture).Length + 1));
            Console.WriteLine("|");

            Console.WriteLine("+--------------------------------------------+--------------+");

            tempBuffer = buffer; // Reset the buffer string for the spacing between items

            // Calculate total
            total = subtotal + tax;

            // Show the final total to the customer
            Console.Write("| Total:                                     | $" + total + tempBuffer.Remove(0, Convert.ToString(total, CultureInfo.InvariantCulture).Length + 1));
            Console.WriteLine("|");

            Console.WriteLine("+--------------------------------------------+--------------+");

            // Wait for user exit
            Console.WriteLine("\nPress any key to exit...");
            Console.Read();

        }
    }
}
