using System;
class Program
{
    static void Main()
    {
        Console.Write("nhap ho ten: ");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("chuoi ho ten hkong duoc rong");
            return;
        }
        input = input.Trim();
        string[] words = input.Split(' ');
        string result = "";
        foreach (string word in words)
        {
            if (word != "")
            {
                string formattedWord =
                    char.ToUpper(word[0]) + word.Substring(1).ToLower();
                result += formattedWord + " ";
            }
        }
        result = result.Trim();
        Console.WriteLine("ho ten khi chuan hoa: " + result);
    }
}
