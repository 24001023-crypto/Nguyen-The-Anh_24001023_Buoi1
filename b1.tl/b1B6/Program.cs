using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1B6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Nhap a= ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b= ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c = ");
            c = double.Parse(Console.ReadLine());
            if(a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phuong trinh co nghiem x = {x:F2}");
                }

                

            }
    }
}
