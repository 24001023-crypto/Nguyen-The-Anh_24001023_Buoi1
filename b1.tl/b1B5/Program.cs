using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1B5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("a /b = " + (a/b));

            }
            catch (FormatException)
            {
                Console.WriteLine("Du lieu phai la so nguyen");
            }
            catch(DivideByZeroException){
                Console.WriteLine("khong the chia cho 0");
            }
            finally { Console.WriteLine("Ket thuc phep tinh"); }
        }
    }
}
