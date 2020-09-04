using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double c)
        {
            var cresult = (c - 32) / 1.8;
            return cresult;
        }

        public static double CelsiusToFahrenheit(double f)
        {
            return (f * 9) / 5 + 32;
        }

    }
}
