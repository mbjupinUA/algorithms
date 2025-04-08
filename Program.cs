using System;
using System.Threading;
using AllAlgorithms.IntroductoryProblems;

namespace AllAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomeBanner();

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
                    ExitAnimation();
                    break;
                }

                AnimateTransition("Opening");

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
                }
            }
        }

        static void ShowWelcomeBanner()
        {
            Console.Clear();
            string[] banner = new string[]
            {
                @"    _    _                  _ _   _                   ",
                @"   / \  | | __ _  ___  _ __(_) |_| |__  _ __ ___  ___ ",
                @"  / _ \ | |/ _` |/ _ \| '__| | __| '_ \| '_ ` _ \/ __|",
                @" / ___ \| | (_| | (_) | |  | | |_| | | | | | | | \__ \",
                @"/_/   \_\_|\__, |\___/|_|  |_|\__|_| |_|_| |_| |_|___/",
                @"           |___/                                      "
            };
            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Random rand = new Random();

            foreach (var line in banner)
            {
                Console.ForegroundColor = colors[rand.Next(colors.Length)];
                Console.WriteLine(line);
                Thread.Sleep(80);
            }

            Console.ResetColor();
            Console.WriteLine("\nWelcome to the Algorithms Hub!");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
            AnimateTransition("Loading Menu");
        }

        static void AnimateTransition(string message = "Loading")
        {
            Console.Clear();
            Console.Write(message);
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }
            Thread.Sleep(300);
            Console.Clear();
        }

        static void ExitAnimation()
        {
            Console.Clear();
            string goodbye = "Thanks for using Algorithms Hub!";
            foreach (char c in goodbye)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("\n\nExiting...");
            Thread.Sleep(1000);
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
                    selected = (selected + 1) % options.Length;
                else if (key == ConsoleKey.UpArrow)
                    selected = (selected - 1 + options.Length) % options.Length;

            } while (key != ConsoleKey.Enter);

            return selected;
        }

        static void Pause(string message)
        {
            Console.Clear();
            Console.WriteLine("\n" + message);
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey(true);
            AnimateTransition("Returning");
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