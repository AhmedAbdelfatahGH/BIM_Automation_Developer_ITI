//using System;
//namespace MyData
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.Clear();
//            //int no = CalcPower(2, 3);
//            int no = CalcRec(5, 3);
//            Console.WriteLine(no);
//            Console.ReadLine();
//        }
//        static int CalcRec(int no, int power)
//        {
//            int total;
//            if (power > 1)
//            {
//                total = no * CalcRec(no, power - 1);
//                return total;
//            }
//            else
//            {
//                total = no;
//            }
//            return total;
//        }
//        //static int CalcPower(int no,int power)
//        //{
//        //    int total = 1;
//        //    for  (int i = 0; i < power; i++)
//        //    {
//        //        total *= no;
//        //    }
//        //    return total;
//        //}
//    }
//}