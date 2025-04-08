using System;
using AllAlgorithms.IntroductoryProblems; // Include the CollatzConjecture class

namespace AllAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] mainOptions = new string[]
                {
                    "Additional Problems",
                    "Advanced Techniques",
                    "Dynamic Programming",
                    "Graph Algorithms",
                    "Introductory Problems",
                    "Mathematics",
                    "Range Queries",
                    "Sorting and Searching",
                    "String Algorithms",
                    "Tree Algorithms",
                    "Exit"
                };

                int selectedOption = DisplayMenu("=== Algorithm Categories Menu ===", mainOptions);

                if (selectedOption == mainOptions.Length - 1)
                {
                    Console.Clear();
                    Console.WriteLine("Exiting...");
                    break;
                }

                switch (selectedOption)
                {
                    case 0:
                        Pause("Additional Problems not implemented yet.");
                        break;
                    case 1:
                        Pause("Advanced Techniques not implemented yet.");
                        break;
                    case 2:
                        Pause("Dynamic Programming not implemented yet.");
                        break;
                    case 3:
                        Pause("Graph Algorithms not implemented yet.");
                        break;
                    case 4:
                        ShowIntroductoryProblemsMenu();
                        break;
                    case 5:
                        Pause("Mathematics not implemented yet.");
                        break;
                    case 6:
                        Pause("Range Queries not implemented yet.");
                        break;
                    case 7:
                        Pause("Sorting and Searching not implemented yet.");
                        break;
                    case 8:
                        Pause("String Algorithms not implemented yet.");
                        break;
                    case 9:
                        Pause("Tree Algorithms not implemented yet.");
                        break;
                    default:
                        break;
                }
            }
        }
        static int DisplayMenu(string title, string[] options)
        {
            int selected = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.WriteLine(title + "\n");
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selected)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"> {options[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("  " + options[i]);
                    }
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= options.Length)
                        selected = 0;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0)
                        selected = options.Length - 1;
                }

            } while (key != ConsoleKey.Enter);

            return selected;
        }
        static void Pause(string message)
        {
            Console.Clear();
            Console.WriteLine("\n" + message);
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey(true);
        }
        static void ShowIntroductoryProblemsMenu()
        {
            string[] introOptions = new string[]
            {
                "Collatz Conjecture",
                "Return to Main Menu"
            };

            int selected = DisplayMenu("=== Introductory Problems ===", introOptions);
            if (selected == 0)
            {
                CollatzConjecture.Run();
                Console.WriteLine("\nPress any key to return to the Introductory Problems menu...");
                Console.ReadKey(true);
                ShowIntroductoryProblemsMenu();
            }
        }
    }
}