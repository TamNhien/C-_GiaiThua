using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so can tinh giai thua: ");
        int sonhap = int.Parse(Console.ReadLine());
        long giaithua = 1;

        for (int i = 1; i <= sonhap; i++)
        {
            giaithua *= i;
        }
        Console.WriteLine($"Giai thua cua {sonhap} la: {giaithua}");
    }
}