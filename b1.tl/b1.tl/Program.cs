using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1.tl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Ho va ten: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nam sinh: ");
            int namsinh;
            if (!int.TryParse(Console.ReadLine(), out namsinh)) {
                Console.WriteLine("Nam sinh khong hop le");
                return;

            }
            int tuoi = DateTime.Now.Year - namsinh;
            Console.WriteLine("Xin chao {0}, tuoi gan dung: {1}", hoTen, tuoi);
                }
    }
}
