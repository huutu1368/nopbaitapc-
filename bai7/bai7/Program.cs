using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap ho ten: ");
        string hoTen = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(hoTen))
        {
            Console.WriteLine("Chuoi null hoac rong -> khong tach");
            return;
        }

        hoTen = hoTen.Trim();
        string[] arr = hoTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mang ket qua null -> khong in");
            return;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
