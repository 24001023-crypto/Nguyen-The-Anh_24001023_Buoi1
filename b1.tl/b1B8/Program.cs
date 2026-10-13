using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Cac so nguyen to khong vuot qua " + n + ":");

        for (int i = 2; i <= n; i++)
        {
            bool prime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
                Console.Write(i + " ");
        }
    }
}