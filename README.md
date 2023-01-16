# Temperature Converter Package
This is a basic temperature converter package that can convert temperatures between Celsius and Fahrenheit.
## Usage
```

class TemperatureConverter
{
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


## Built with

* Languages: C#
* Frameworks: .NET Standard 2.0
* Technologies: Github and Visual Studio

## Getting started
* To install our package using the .NET CLI, ```dotnet add package basictempconverter --version 1.0.2```
* Installation using Visual Studio
    + Right-click on project dependencies
    + Select manage Nuget packages
    + Search basictempconverter
    + Click install
    + After installing, add to your project dependencies
    + Import the namespace 'using basictempconverter'
    + It has a single 'Temperature' class and two static methods for converting to celcius and fahrenheit
## Note

It's important to mention that this is a basic implementation of a temperature converter and as such it is not intended to be used in any scientific or critical applications, it's just for demonstration purposes.
## Repo
https://github.com/jaguar48/Temperature-converter
