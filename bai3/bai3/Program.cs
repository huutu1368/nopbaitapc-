using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("khong doi xung");
            return;
        }
        string s = "";

        foreach (char c in input)
        {
            if (c != ' ')
            {
                s += c;
            }
        }
        int left = 0;
        int right = s.Length - 1;
        bool doiXung = true;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                doiXung = false;
                break;
            }
            left++;
            right--;
        }
        if (doiXung)
            Console.WriteLine("Đoi xung");
        else
            Console.WriteLine("Khong doi xung");
    }
}
