/**
 * Tasks
 * [X] Assignment01
 * [X] Assignment02
 * [X] Assignment03
 * [X] Assignment04
 * [ ] Assignment05  (CHAT GPT)
 */

using System;

struct Program
{
    static void Main()
    {
        //Assignment01();
        //Assignment02();
        //Assignment03();
        //Assignment04();
        //Assignment05();
    }

    static void Assignment01()
    {
        Console.WriteLine("Please Enter an ASCII");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int asciiValue))
        {
            char character = (char)asciiValue;
            Console.WriteLine(character);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid ASCII value.");
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static void Assignment02()
    {
        Console.WriteLine("Please Enter a Number");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter a Number");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void Assignment03()
    {
        int sum = 0;
        int num;

        Console.WriteLine("Keep entering numbers. The sum must be less than 100.");

        do
        {
            Console.WriteLine("Please Enter a Number:");
            num = int.Parse(Console.ReadLine());

            sum += num;

        } while (sum < 100);

        Console.WriteLine("Sum = {0}", sum);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void Assignment04()
    {
        char input;

        do
        {
            Console.Clear();
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("A) HIII");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("B) WELCOME");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("C) EXIT");

            input = char.ToUpper(Console.ReadKey().KeyChar);

            Console.Clear();

            switch (input)
            {
                case 'A':
                    Console.WriteLine("HIII!");
                    break;
                case 'B':
                    Console.WriteLine("WELCOME!");
                    break;
                case 'C':
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose A, B, or C.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();

        } while (input != 'C');

        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }

    static void Assignment05()
    {
        const int startX = 5;  
        const int startY = 5;
        const int cellWidth = 4;
        const int cellHeight = 2; 

        Console.Clear();
        Console.WriteLine("The Magic Box Matrix");
        Console.WriteLine("--------------------");
        Console.Write("Enter an odd number for the size of the Magic Square: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Please enter an odd number.");
            return;
        }

        int[,] magicSquare = new int[n, n];

        int x = n / 2;  
        int y = 0;      

        magicSquare[y, x] = 1;

        for (int i = 2; i <= n * n; i++)
        {
            int newX = (x + 1) % n;
            int newY = (y - 1 + n) % n;

            if (magicSquare[newY, newX] != 0)
            {
                newX = x;   
                newY = (y + 1) % n;  
            }

            magicSquare[newY, newX] = i;

            x = newX;
            y = newY;
        }

        Console.Clear();
        Console.WriteLine("Generated Magic Square:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.SetCursorPosition(startX + col * cellWidth, startY + row * cellHeight);
                Console.Write(magicSquare[row, col].ToString().PadLeft(2));
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

























