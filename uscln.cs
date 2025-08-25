//using System;

//namespace BaitapC_
//{
//    public class SoUSCLN
//    {
     
//        public static int USCLN(int a, int b)
//        {
//            a = Math.Abs(a);
//            b = Math.Abs(b);

//            while (a != b)
//            {
//                if (a > b)
//                    a = a - b;
//                else
//                    b = b - a;
//            }
//            return a;
//        }

//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.InputEncoding = System.Text.Encoding.UTF8;
//            Console.Write("Nhập số nguyên dương:"); 
//            int a = int.Parse(Console.ReadLine() ?? "0");
//            Console.Write("Nhập số nguyên dương:");
//            int b = int.Parse(Console.ReadLine() ?? "0");
//            Console.WriteLine("Ước chung lớn nhất là: " + USCLN(a, b));
//        }
//    }
//}
