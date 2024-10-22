using System;

class CountVowelsConsonants
{
    static void Main()
    {
        string input = "Hello, World!";
        int vowels = 0, consonants = 0;

        foreach (char c in input.ToLower())
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }
}
