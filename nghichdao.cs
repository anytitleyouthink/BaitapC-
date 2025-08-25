//using System;

//namespace BaitapC_
//{
//    internal class Nghichdao
//    {
//        static int Reverse(int n)
//        {
//            int a = 0;
//            n = Math.Abs(n);  // Lấy giá trị tuyệt đối để tránh số âm

//            while (n > 0)
//            {
//                a = a * 10;       // dịch sang trái
//                a = a + n % 10;   // lấy chữ số cuối
//                n = n / 10;       // bỏ chữ số cuối
//            }

//            return a;
//        }

//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.InputEncoding = System.Text.Encoding.UTF8;

//            Console.Write("Nhập số nguyên dương: ");
//            int n = int.Parse(Console.ReadLine() ?? "0");

//            Console.WriteLine("Số đảo ngược là: " + Reverse(n));
//        }
//    }
//}
