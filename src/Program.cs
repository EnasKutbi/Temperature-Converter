using System;
class TemperatureConverter
{

    public static void Main(string[] args)
    {

        try
        {
            while (true)
            {
                Console.Write("Enter temperature Value and its unit (C or F), or type Q to exit: ");
                string input = Console.ReadLine() ?? "";

                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                string[] parts = input.Split(" ");

                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid input. Please enter a temperature value and its unit.");
                    continue;
                }

                string temperatureUnit = parts[1].ToUpper();
                if (temperatureUnit != "C" && temperatureUnit != "F")
                {
                    Console.WriteLine("Invalid Unit. Please enter C or F as temperature unit.");
                    continue;
                }

                if (!double.TryParse(parts[0], out double temperatureValue))
                {
                    Console.WriteLine("Invalid Unit. Please enter a numeric value for temperature.");
                    continue;
                }

                Console.WriteLine($"Converted: {input} = {TempConvert(temperatureValue, temperatureUnit)}");

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }

    public static string TempConvert(double tempValue, string unit)
    {

        double newTempValue;
        string result;
        switch (unit)
        {
            case "C":
                newTempValue = (tempValue * 9 / 5) + 32;
                result = $"{newTempValue} F";
                break;

            case "F":
                newTempValue = (tempValue - 32) * 5 / 9;
                result = $"{newTempValue} C";
                break;

            default:
                result = "Invalid";
                break;
        }
        return result;
    }
}