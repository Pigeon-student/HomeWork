using System;
class Fibo
{
    static void Main()
    {

        Console.Write("Let's do number like Fibonacci did! Enter number: ");

        int number = ReadFromConsole();
        Console.WriteLine($"Italian version: {FibonacciNumber(number)}");

        static int ReadFromConsole()
        {
            string input = Console.ReadLine();

            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Wrong number");
                return 0;
            }
        }

        static int FibonacciNumber(int result)
        {
            if (result == 1) return 0;
            if (result == 2) return 1;

            return FibonacciNumber(result - 1) + FibonacciNumber(result - 2);
        }

    }
}
