using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem cua ban: ");
            double diem;
            if (!double.TryParse(Console.ReadLine(), out diem) || diem < 2 || diem > 10)
            {
                Console.WriteLine("Diem phai thuoc [0-10]");

            }
            else if (diem >= 9) Console.WriteLine("Xuat sac");
            else if (diem >= 8) Console.WriteLine("Gioi");
            else if (diem >= 6.5) Console.WriteLine("Kha");
            else if (diem >= 5) Console.WriteLine("Trung binh");
            else Console.WriteLine("Yeu");
        }
    }
}
