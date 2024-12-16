//using System;
//namespace MyData
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.Clear();
//            Console.Write("Pleasr Write Number: ");
//            int x=int.Parse(Console.ReadLine());    
//            PrintBin(x);
//            Console.ReadLine();
//        }
//        static void PrintBin (int no)
//        {
//            int div = no /2;
//            int mod = no %2;
//            if (no>1)
//            {
//                PrintBin(div);
//            }
//            else
//            {
//                Console.Write(1);
//            }
//            Console.Write(mod);
//        }
//    }
//}