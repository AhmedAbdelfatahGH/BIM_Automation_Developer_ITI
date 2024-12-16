//using System;
//struct Program
//{
//    static void Main()
//    {
//        Console.Clear();
//        Employee[] emps = new Employee[10];


//        for (int i = 1; i < emps.Length; i++)
//        {
//            Console.Write("Name of employee #{0}: ", i);
//            emps[i].Name = Console.ReadLine();
//            Console.Write("Age of employee #{0}: ", i);
//            emps[i].Age = int.Parse(Console.ReadLine());
//            Console.Write("Salary of employee #{0}: ", i);
//            emps[i].Salary = float.Parse(Console.ReadLine());
//        }

//        Console.ReadLine();

//    }
//    static int Getintfromuser(string msg)
//    {
//        Console.Write(msg + "");
//        return int.Parse(Console.ReadLine());
//    }

//}
//struct Employee
//{
//    public int Age;
//    public string Name;
//    public float Salary;
//}