namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitCelsius(double Fahrenheit)
    {
        return (Fahrenheit - 32) * 5 / 9;
    }

    public static double CelsiusToFahrenheit(double Celsius)
    {
        return (Celsius * 9 / 5) + 32;
    }
}