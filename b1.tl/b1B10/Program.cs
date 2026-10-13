using System;

class Program
{
    static void Main()
    {
        int choice;

        Console.WriteLine("===== MENU =====");
        Console.WriteLine("1. Tam giac vuong dac");
        Console.WriteLine("2. Tam giac vuong rong");
        Console.WriteLine("3. Hinh vuong rong");
        Console.Write("Chon hinh: ");
        choice = int.Parse(Console.ReadLine());

        Console.Write("Nhap kich thuoc: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Kich thuoc phai lon hon 0");
            return;
        }

        switch (choice)
        {
            case 1:
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");

                    Console.WriteLine();
                }
                break;

            case 2:
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j == 1 || j == i || i == n)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }
                break;

            case 3:
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == 1 || i == n || j == 1 || j == n)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Lua chon khong hop le");
                break;
        }
    }
}