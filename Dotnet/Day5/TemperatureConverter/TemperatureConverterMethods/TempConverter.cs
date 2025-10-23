namespace TemperatureConverterMethods
{
    public class TempConverter
    {
        public void CelsiusToFahrenheit(double temperature)
        {
            if(TemperatureValidator.IsValidator(temperature))
            {
                Console.WriteLine($"{temperature} C to Fahrenheit is {(temperature * (1.8)) + 32}");
            }
            else
            {
                Console.WriteLine("Enter valid temperature");
            }
        }

        public void FahrenheitToCelsius(double temperature)
        {
            double result = (temperature - 32) * 5 / 9;

            if (TemperatureValidator.IsValidator(result))
            {
                Console.WriteLine($"{temperature} F to Celsius is {result}");
            }
            else
            {
                Console.WriteLine("Enter valid temperature");
            }
        }
    }
}
