using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapC_
{
    internal class Hoandoi
    {
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên a: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập số nguyên b: ");
            int b = int.Parse(Console.ReadLine() ?? "0");
            Swap(ref a, ref b);
            Console.WriteLine($"Sau khi hoán đổi: a = {a}, b = {b}");
        }
    }
    
}
