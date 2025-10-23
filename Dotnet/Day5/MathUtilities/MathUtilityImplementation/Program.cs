using MathUtilities;

Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine());

MathUtilities.MathUtilities mathUtilities = new MathUtilities.MathUtilities();
Console.WriteLine(mathUtilities.IsEven(num));
Console.WriteLine(mathUtilities.IsPrime(num));
Console.WriteLine(mathUtilities.Factorial(num));   
