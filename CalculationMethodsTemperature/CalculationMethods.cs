﻿namespace CalculationTemperature
{
    public class CalculationMethods
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;

            //hey
        }
        

        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
        
        

    }
}