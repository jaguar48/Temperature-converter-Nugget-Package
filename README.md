# Temperature Converter Package
This is a basic temperature converter package that can convert temperatures between Celsius and Fahrenheit.
## Usage
```
using System;

class TemperatureConverter
{
    public static double CelsiusToFahrenheit(double celsius) => (celsius * 9/5) + 32;
    public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5/9;

    public static void Main()
    {
        Console.WriteLine("Enter a temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        Console.WriteLine(celsius + " degrees Celsius is " + CelsiusToFahrenheit(celsius) + " degrees Fahrenheit.");

        Console.WriteLine("Enter a temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine(fahrenheit + " degrees Fahrenheit is " + FahrenheitToCelsius(fahrenheit) + " degrees Celsius.");
    }
}
```

In the Main method, the program prompts the user to enter a temperature in either Celsius or Fahrenheit. The program then converts the temperature to the other unit and prints the result.

## Conversion Formulas
The conversion formulas used in this program are as follows:

Celsius to Fahrenheit: (celsius * 9/5) + 32

Fahrenheit to Celsius: (fahrenheit - 32) * 5/9

## Note

It's important to mention that this is a basic implementation of a temperature converter and as such it is not intended to be used in any scientific or critical applications, it's just for demonstration purposes.
## Repo
https://github.com/jaguar48/Temperature-converter
