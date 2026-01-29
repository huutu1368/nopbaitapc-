using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine(0);
            return;
        }

        input = input.Trim();

        if (input == "")
        {
            Console.WriteLine(0);
            return;
        }

        string[] words = input.Split(' ');
        int count = 0;

        foreach (string word in words)
        {
            if (word != "")
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
