namespace Temperature_converter
{
    public class Temperature
    {
        public static double CelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

        public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

    }
}