using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap câu: ");
        string input = Console.ReadLine();

        if (input == null)
        {
            return;
        }

        input = input.Trim();

        if (input == "")
        {
            return;
        }

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words == null || words.Length == 0)
        {
            return;
        }

        string longest = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }

        Console.WriteLine(longest);
    }
}
