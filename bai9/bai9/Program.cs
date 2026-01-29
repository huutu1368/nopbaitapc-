using System;
namespace Bai9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] danhSach = new string[]
            {
                "Lap Trinh C#",
                null,
                "",
                "   ",
                "Visual Studio"
            };

            Console.WriteLine("Dang Kiem Tra Mang Mau...");

            int dem = 0;
            foreach (string phanTu in danhSach)
            {
                if (!string.IsNullOrEmpty(phanTu))
                {
                    dem++;
                    Console.WriteLine($"- Tim Thay Chuoi Hop Le: \"{phanTu}\"");
                }
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Tong So Phan Tu La: {dem}");
            Console.ReadLine();
        }
    }
}