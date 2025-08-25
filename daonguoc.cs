//using System;

//namespace BaitapC_
//{
//    internal class Songhichdao
//    {
//        // Hàm đảo ngược số
//        static int Reverse(int n)
//        {
//            int a = 0;
//            n = Math.Abs(n);  // lấy trị tuyệt đối để tránh số âm

//            while (n > 0)
//            {
//                a = a * 10 + n % 10;
//                n /= 10;
//            }
//            return a;
//        }

        
//        static bool Symmetry(int n)
//        {
//            int songuoc = Reverse(n);
//            return songuoc == n;
//        }

//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.InputEncoding = System.Text.Encoding.UTF8;

//            Console.Write("Nhập số nguyên dương: ");
//            int n = int.Parse(Console.ReadLine() ?? "0");

//            if (Symmetry(n))
//                Console.WriteLine("{0} là số đối xứng", n);
//            else
//                Console.WriteLine("{0} không phải là số đối xứng", n);
//        }
//    }
//}
