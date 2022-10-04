using System.Globalization;

namespace CalculationTemperature;

public static class CalculationMethods
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return Convert.ToDouble(Math.Round(celsius * 9 / 5 + 32, 3), new CultureInfo("en-US"));
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return Convert.ToDouble(Math.Round((fahrenheit - 32) * 5 / 9, 3), new CultureInfo("en-US"));
    }


    public static double CelsiusToKelvin(double celsius)
    {
        return Math.Round(celsius + 273.15, 3);
    }

    public static double KelvinToCelsius(double kelvin)
    {
        return Math.Round(kelvin - 273.15, 3);
    }
}