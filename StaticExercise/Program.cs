namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitCelsius(54);
            Console.WriteLine($"54° Fahrenheit is {Math.Round(celsius, 2)}° degrees Celsius.");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"It is {fahrenheit}° Fahrenheit converted back.");
        }
    }
}