using AssignmentDay2;

//Print first 20 numbers using for loop
FirstTwentyNumbers.FirstTwenty();

//Print odd numbers less than 50 using while loop
OddNumbers.OddNumber();

//Large amount 3 numbers
Console.WriteLine("ENTER THREE NUMBERS");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
Largest.LargestAmongThree(num1, num2, num3);

//Reverse of a number
Console.WriteLine("ENTER THE NUMBER TO BE REVERSED");
int num4 = int.Parse(Console.ReadLine());
ReverseOfNumber.ReverseOfANumber(num4);

//Sum of the digits of a number
Console.WriteLine("ENTER THE NUMBER WHOSE SUM IS TO BE FINDED");
int num5 = int.Parse(Console.ReadLine());
SumofDigits.SumOfDigits(num5);

//Check prime number
Console.WriteLine("ENTER THE NUMBER");
int num6 = int.Parse(Console.ReadLine());
CheckPrime.CheckPrimeNum(num6);

//Print all prime numbers below 100
PrimeNumbersUptoARange.PrimeNumbersUptoRange();

//Fibonacci series
Fibonacci.FibonacciSeries();

//Tax calculation program, input the amount and display the tax
Console.WriteLine("ENTER THE AMOUNT");
int amount = int.Parse(Console.ReadLine());
TaxProblem.TaxProblems(amount);

//Input a character from console and display the sports name corresponding to it
Console.WriteLine("ENTER ANY CHARACTER FROM BELOW LIST");
Console.WriteLine("1.c /n2.f /n3.h /n4.t /n5.b");
char character = char.Parse(Console.ReadLine());
SportsCharacter.SportsCharacters(character);






