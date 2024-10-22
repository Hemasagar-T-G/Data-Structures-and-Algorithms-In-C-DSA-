using System;

class PalindromeCheck
{
    static void Main()
    {
        string input = "madam";
        string reversed = new string(input.ToCharArray().Reverse().ToArray());
        bool isPalindrome = input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
    }
}
