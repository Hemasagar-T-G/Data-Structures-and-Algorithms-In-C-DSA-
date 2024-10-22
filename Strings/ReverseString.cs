using System;

class ReverseString
{
    static void Main()
    {
        string input = "Hello, World!";
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine(reversed);
    }
}
