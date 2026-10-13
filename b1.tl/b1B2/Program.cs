using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h;
            Console.WriteLine("Ban kinh r = ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)return;
            Console.WriteLine("Chieu cao h = ");
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0)return;

            double dientichXQ = 2 * Math.PI * r * h;
            double thetich = Math.PI * r * r * h;
            Console.WriteLine("Sxq={0:N2}; V={1:N2}", dientichXQ, thetich);
        }
    }
}
