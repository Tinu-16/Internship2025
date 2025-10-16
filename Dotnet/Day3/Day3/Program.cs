using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using Day3;

////Input two numbers and perform all arithmetic operations (+, -, *, /, %).
//Console.WriteLine("Enter 2 numbers");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
//arithmeticOperations.Add(num1, num2);
//arithmeticOperations.Subtract(num2, num1);
//arithmeticOperations.Multiplication(num1, num2);
//arithmeticOperations.Division(num1, num2);

////Check whether a number is even or odd using the ternary operator.
//Console.WriteLine("Enter a numbers");
//int num3 = int.Parse(Console.ReadLine());
//Console.WriteLine(EvenOrOdd.EvenOrOddCheck(num3));

//Compare two integers using relational and logical operators.
Console.WriteLine("Enter 2 numbers");
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());
NumberComparison.NumberComparisonUsingRelational(num4, num5);
NumberComparison.NumberComparisonUsingLogical(num4);

//Swap two numbers without using a third variable (use arithmetic).
Console.WriteLine("Enter 2 numbers");
int num15 = int.Parse(Console.ReadLine());
int num6 = int.Parse(Console.ReadLine());
SwapUsingArithmetic.SwapUsingArithmetics(num15, num6);

//Check if a number lies between 10 and 50 using logical operators.
Console.WriteLine("Enter a numbers");
int num7 = int.Parse(Console.ReadLine());
NumbersBetweenTenAndFifty numbersBetweenTenAndFifty = new NumbersBetweenTenAndFifty();
numbersBetweenTenAndFifty.NumberBetweenTenAndFifty(num7);

//Simulate a simple calculator using a switch statement and arithmetic operators.
Console.WriteLine("Enter 2 numbers");
int num8 = int.Parse(Console.ReadLine());
int num9 = int.Parse(Console.ReadLine());
Calculator calculator = new Calculator();
calculator.CalculatorResult(num8, num9);

//Create a class Student with fields Name and Age. Add a constructor to initialize them and display details in a separate method .
Student student = new Student("Anuja", 45);
student.DisplayMethod();

//Create a class Employee with two constructors (Name only; Name, Salary) using constructor chaining.
Employee employee = new Employee("Tinu", 25000);

//Create a class BankAccount(AccountNumber, AccountHolder, Balance ) with default and parameterized constructors using constructor chaining.
//Add Deposit() which increments the balance and DisplayBalance() to display the account details methods.
BankAccount bankAccount = new BankAccount(68522214555, "Tinu", 10000);
bankAccount.DisplayBalance();
bankAccount.Deposit(1000);
bankAccount.DisplayBalance();

//Swap two integers using the ref keyword.
Console.WriteLine("Enter 2 numbers");
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
SwapUsingRef swapUsingRef = new SwapUsingRef();
swapUsingRef.SwapUsingRefKeyword(ref c, ref d);
Console.WriteLine("After swapping a is " + c);
Console.WriteLine("After swapping b is " + d);

//Write a method GetSumAndAverage(int a, int b, out int sum, out double avg) that returns sum and average using out parameters.
Console.WriteLine("Enter 2 numbers");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int sum;
double avg;
GetSumAndAverage.GetSumAndAverageofNumbers(a, b, out sum, out avg);

//Write a method FindMaxMin(int[] arr, out int max, out int min) that finds maximum and minimum using out.
Console.WriteLine("Enter the 5 elements of the array");
int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
FindMaxMin findMaxMin = new FindMaxMin();
findMaxMin.FindMaxMinInArray(arr, out int max, out int min);
Console.WriteLine("Max element is "+max);
Console.WriteLine("Min element is " + min);

