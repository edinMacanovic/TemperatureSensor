using System.Globalization;

namespace TemperatureConverter.Models;

/// <summary>
/// This class contains the calculation methods for the temperature converter.
/// </summary>
public static class CalculationMethods
{

    
    /// <summary>
    /// This Method converts Celsius to Fahrenheit.
    /// <summary>
    /// <param name="celsius">This Parameter is the Value that i get from the TextBox1 in the Forms.CS</param>
    /// <returns>Calculated Fahrenheit</returns> 
    public static double CelsiusToFahrenheit(double celsius)
    {
        return Convert.ToDouble(Math.Round(celsius * 9 / 5 + 32, 3), new CultureInfo("en-US"));
    }




    
    /// <summary>
    /// This Method converts Fahrenheit to Celsius.
    /// <summary>
    /// <param name="fahrenheit">This Parameter is the Value that i get from the TextBox1 in the Forms.CS</param>
    /// <returns>Calculated Celsius</returns> 
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return Convert.ToDouble(Math.Round((fahrenheit - 32) * 5 / 9, 3), new CultureInfo("en-US"));
    }




    
    /// <summary>
    /// This Method converts Celsius to Kelvin.
    /// <summary>
    /// <param name="celsius">This Parameter is the Value that i get from the TextBox1 in the Forms.CS</param>
    /// <returns>Calculated Kelvin</returns> 
    public static double CelsiusToKelvin(double celsius)
    {
        return Math.Round(celsius + 273.15, 3);
    }


    
    /// <summary>
    /// This Method converts Kelvin to Celsius.
    /// <summary>
    /// <param name="kelvin">This Parameter is the Value that i get from the TextBox1 in the Forms.CS</param>
    /// <returns>Calculated Celsius</returns> 
    public static double KelvinToCelsius(double kelvin)
    {
        return Math.Round(kelvin - 273.15, 3);
    }
    
}