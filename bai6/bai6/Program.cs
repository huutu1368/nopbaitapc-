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

        if (arr == null)
        {
            Console.WriteLine(0);
            return;
        }

        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
