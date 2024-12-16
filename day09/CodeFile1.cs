using System;
struct Program
{
    static void Main()
    {
        Console.Clear();
        string[] students = { "Salah", "Ali", "Layla", "Hassan" };
        string[] subject = { "Science", "Math", "English" };
        int[,] grades = new int[students.Length, subject.Length];


        int x = 15;
        for (int i = 0; i < subject.Length; i++, x += 15)
        {
            Console.SetCursorPosition(x, 1);
            Console.Write(subject[i]);
        }
        for (int i = 0; i < students.Length; i++)
        {
            Console.SetCursorPosition(1, (2 + i) * 2);
            Console.Write(students[i]);
        }
        Console.SetCursorPosition(x, 1);
        Console.WriteLine("Total");
        /////////////////
        int[] totals = new int[students.Length];
        for (int j = 0, k = 4; j < students.Length; j++, k += 2)
        {
            int m = 15;
            for (int i = 0; i < subject.Length; i++, m += 15)
            {
                Console.SetCursorPosition(m, k);
                grades[j, i] = Getintfromuser("");
                totals[j] += grades[j, i];
            }
            Console.SetCursorPosition(m, k);
            Console.WriteLine(totals[j]);

        }
        ///////////////////
        Console.ReadLine();

    }
    static int Getintfromuser(string msg)
    {
        Console.Write(msg + "");
        return int.Parse(Console.ReadLine());
    }

}