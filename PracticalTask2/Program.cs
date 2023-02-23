using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Please enter an integer in decimal and a new base number system (from 2 to 20) as command line arguments.");
            return;
        }

        int decimalNumber;
        if (!int.TryParse(args[0], out decimalNumber))
        {
            Console.WriteLine("Please enter a valid integer in decimal.");
            return;
        }

        int newBase;
        if (!int.TryParse(args[1], out newBase) || newBase < 2 || newBase > 20)
        {
            Console.WriteLine("Please enter a valid new base number system (from 2 to 20).");
            return;
        }

        Console.WriteLine($"The decimal number {decimalNumber} in base {newBase} is: {ConvertToBase(decimalNumber, newBase)}");
    }

    static string ConvertToBase(int decimalNumber, int newBase)
    {
        string digits = "0123456789ABCDEFGHIJ"; // Used to convert remainder to base
        string result = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % newBase;
            result = digits[remainder] + result;
            decimalNumber /= newBase;
        }

        return result;
    }
}
