using System;

namespace AllAlgorithms.IntroductoryProblems
{
    public static class CollatzConjecture
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== Collatz Conjecture ===");
            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n > 0)
            {
                Console.WriteLine("\nCollatz sequence:");
                while (n != 1)
                {
                    Console.Write(n + " ");
                    // If n is even, divide by 2; if odd, multiply by 3 and add 1.
                    n = (n % 2 == 0) ? n / 2 : 3 * n + 1;
                }
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}