using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithExceptions
{
    internal class SimpleCalculator
    {
        public void CalculatorResult()
        {
            bool flag = true;
            while (flag)
            {
                try 
                {
                    Console.WriteLine("Enter 2 numbers.");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choose the operation to be performed");
                    Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(num1 + num2);
                            break;
                        case 2:
                            Console.WriteLine(num1 - num2);
                            break;
                        case 3:
                            Console.WriteLine(num1 * num2);
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine(num1 / num2);
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Error: The number cannot be divided by zero");
                            }
                            break;
                        default:
                            Console.WriteLine("Choose a valid option");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a numeric value.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: The number entered is too large or too small.");
                }
                finally
                {
                    Console.Write("\nWould you like to perform another calculation? (y/n): ");
                    string? answer = Console.ReadLine();
                    flag = (answer?.Trim().ToLower() == "y");
                }
            }
        }
    }
}
