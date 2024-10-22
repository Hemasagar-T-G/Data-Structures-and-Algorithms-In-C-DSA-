using System;
using System.Collections.Generic;

class CharacterFrequency
{
    static void Main()
    {
        string input = "hello";
        var frequency = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }

        foreach (var kvp in frequency)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
