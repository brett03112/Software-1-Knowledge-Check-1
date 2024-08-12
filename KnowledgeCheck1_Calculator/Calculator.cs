using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// Implements the Add method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Returns first added by second</returns>
        public int Add(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// Implements the Subtract method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Returns first subtracted by second</returns>
        public int Subtract(int first, int second)
        {
            return first - second;
        }

        /// <summary>
        /// Implements the Multiply method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Returns first multiplied by second</returns>
        public int Multiply(int first, int second)
        {
            return first * second;
        }

        /// <summary>
        /// Implements the Divide method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>
        /// Returns first divided by second
        /// </returns>
        public double Divide(double first, double second)
        {
            return first / second;                        
        }

        /// <summary>
        /// Takes a string a and returns a valid int
        /// </summary>
        /// <param name="a"></param>
        /// <returns>
        /// Returns a valid int for use in the Add, Subtract, and Multiply methods
        /// </returns>
        public int ReturnValidInput(string a)
        {
            if (int.TryParse(a, out int numA))
            {
                return numA;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("One or more of the numbers is not an int. Please try again.");
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out numA))
                    {
                        return numA;
                    }
                    continue;
                }
            }
        }

        /// <summary>
        /// Checks if the user input is valid for the Divide method
        /// Makes sure the user does not divide by 0 or an empty string
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True is valid, false if not</returns>
        public bool IsValidInputDivide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by 0. Please try again.");
                return false;
            }
            return true;    
        }

        /// <summary>
        /// Takes a string a and returns a valid double for the Divide method
        /// </summary>
        /// <param name="a"></param>
        /// <returns>A valid double to be used in the Divide method</returns>
        public double ReturnValidInputDivide(string a)
        {
            if (double.TryParse(a, out double numA))
            {
                return numA;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("This input is not a double. Please enter a valid double.");
                    var input = Console.ReadLine();
                    if (double.TryParse(input, out double numB))
                    {
                        return numB;
                    }
                    continue;
                }
            }
        }
    }
}
