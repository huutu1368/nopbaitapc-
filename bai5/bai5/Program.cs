using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = null;

        if (n > 0)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        if (arr == null || arr.Length == 0)
        {
            return;
        }

        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.Write(" Phan tu lon nhat trong mang la: ");
        Console.WriteLine(max);
    }
}
