using System;

class ReverseNumber
{
    static void Main()
    {
        int number = 12345; // You can change this to any integer
        int reversed = 0;

        while (number != 0)
        {
            int digit = number % 10; // Get the last digit
            reversed = reversed * 10 + digit; // Build the reversed number
            number /= 10; // Remove the last digit
        }

        Console.WriteLine($"Reversed Number: {reversed}");
    }
}
