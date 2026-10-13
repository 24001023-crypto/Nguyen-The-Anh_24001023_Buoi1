using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so tu 0 den 99: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 99)
        {
            Console.WriteLine("So khong hop le");
            return;
        }

        if (n < 10)
        {
            switch (n)
            {
                case 0: Console.WriteLine("Khong"); break;
                case 1: Console.WriteLine("Mot"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bon"); break;
                case 5: Console.WriteLine("Nam"); break;
                case 6: Console.WriteLine("Sau"); break;
                case 7: Console.WriteLine("Bay"); break;
                case 8: Console.WriteLine("Tam"); break;
                case 9: Console.WriteLine("Chin"); break;
            }
        }
        else
        {
            int chuc = n / 10;
            int donvi = n % 10;

            switch (chuc)
            {
                case 1: Console.Write("Muoi"); break;
                case 2: Console.Write("Hai muoi"); break;
                case 3: Console.Write("Ba muoi"); break;
                case 4: Console.Write("Bon muoi"); break;
                case 5: Console.Write("Nam muoi"); break;
                case 6: Console.Write("Sau muoi"); break;
                case 7: Console.Write("Bay muoi"); break;
                case 8: Console.Write("Tam muoi"); break;
                case 9: Console.Write("Chin muoi"); break;
            }

            if (donvi != 0)
            {
                switch (donvi)
                {
                    case 1:
                        if (chuc > 1)
                            Console.Write(" mot");
                        else
                            Console.Write(" mot");
                        break;
                    case 2: Console.Write(" hai"); break;
                    case 3: Console.Write(" ba"); break;
                    case 4: Console.Write(" bon"); break;
                    case 5:
                        if (chuc == 1)
                            Console.Write(" mot");
                        else
                            Console.Write(" lam");
                        break;
                    case 6: Console.Write(" sau"); break;
                    case 7: Console.Write(" bay"); break;
                    case 8: Console.Write(" tam"); break;
                    case 9: Console.Write(" chin"); break;
                }
            }

            Console.WriteLine();
        }
    }
}