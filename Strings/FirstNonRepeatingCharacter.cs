using System;
using System.Collections.Generic;

class FirstNonRepeatingCharacter
{
    static void Main()
    {
        string input = "swiss";
        var charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        char firstNonRepeating = '\0';
        foreach (char c in input)
        {
            if (charCount[c] == 1)
            {
                firstNonRepeating = c;
                break;
            }
        }

        Console.WriteLine(firstNonRepeating == '\0' ? "No non-repeating character" : firstNonRepeating.ToString());
    }
}
