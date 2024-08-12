using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            int inputInt = int.Parse(input);

            var calculator = new Calculator();

            switch (inputInt)
            {
                case 1: // addition
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = Console.ReadLine();
                    int addNumOne = calculator.ReturnValidInput(addNumber1);

                    var addNumber2 = Console.ReadLine();
                    int addNumTwo = calculator.ReturnValidInput(addNumber2);

                    Console.WriteLine($"{addNumOne} + {addNumTwo} = " +
                        $"{calculator.Add(addNumOne, addNumTwo)}");    
                    break;

                case 2: // subtraction
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subtractNumber1 = Console.ReadLine();
                    int subtractNumOne = calculator.ReturnValidInput(subtractNumber1);

                    var subtractNumber2 = Console.ReadLine();
                    int subtractNumTwo = calculator.ReturnValidInput(subtractNumber2);

                    Console.WriteLine($"{subtractNumOne} - {subtractNumTwo} = " +
                        $"{calculator.Subtract(subtractNumOne, subtractNumTwo)}");
                    
                    break;

                case 3: // multiplication
                    Console.WriteLine("Enter 2 integers to multiply: ");
                    var multiplyNumber1 = Console.ReadLine();
                    int multNumOne = calculator.ReturnValidInput(multiplyNumber1);

                    var multiplyNumber2 = Console.ReadLine();
                    int multNumTwo = calculator.ReturnValidInput(multiplyNumber2);

                    Console.WriteLine($"{multNumOne} * {multNumTwo} = " +
                        $"{calculator.Multiply(multNumOne, multNumTwo)}");

                    break;

                case 4: // division
                    Console.WriteLine("Enter 2 doubles to divide");
                    var divideNumber1 = Console.ReadLine();
                    double divideNumOne = calculator.ReturnValidInputDivide(divideNumber1);

                    var divideNumber2 = Console.ReadLine();
                    double divideNumTwo = calculator.ReturnValidInputDivide(divideNumber2);

                                       
                    while (!calculator.IsValidInputDivide(divideNumOne, divideNumTwo))
                    {
                        Console.WriteLine("Enter 2 doubles to divide");
                        divideNumber1 = Console.ReadLine();
                        divideNumOne = calculator.ReturnValidInputDivide(divideNumber1);

                        divideNumber2 = Console.ReadLine();
                        divideNumTwo = calculator.ReturnValidInputDivide(divideNumber2);

                        if (calculator.IsValidInputDivide(divideNumOne, divideNumTwo))
                        {
                            break;
                        }
                        continue;
                    }
                    
                    Console.WriteLine($"{divideNumOne} / {divideNumTwo} = " +
                        $"{calculator.Divide(divideNumOne, divideNumTwo)}");
                    
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}