using TemperatureConverterMethods;

TempConverter tempConverter = new TempConverter();
Console.WriteLine("Enter the celsius temperature to be converted to Fahrenheit");
double temperature = double.Parse(Console.ReadLine());
tempConverter.CelsiusToFahrenheit(temperature);


Console.WriteLine("Enter the Fahrenheit temperature to be converted to celsius");
double temperature1 = double.Parse(Console.ReadLine());
tempConverter.FahrenheitToCelsius(temperature1);