// Written by Kapil
// Feb 5 2025

using System;

namespace HomeWork2
{
    public class Program
    {
        static void Main(string[] args)
        {
            HomeWork2 homework = new HomeWork2();

            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Watchtower");
            Console.WriteLine("2. Buying Inventory");
            Console.WriteLine("3. Discounted Inventory");
            Console.WriteLine("4. The Prototype");
            Console.WriteLine("5. The Magic Cannon");
            Console.WriteLine("6. The Replicator of D'To");
            Console.Write("Enter your choice (1-6): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter X coordinate: ");
                    homework.XCoordinate = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Y coordinate: ");
                    homework.YCoordinate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(homework.GetEnemyDirection());
                    break;
                case 2:
                case 3:
                    Console.WriteLine("The following items are available:");
                    Console.WriteLine("1 - Rope");
                    Console.WriteLine("2 - Torches");
                    Console.WriteLine("3 - Climbing Equipment");
                    Console.WriteLine("4 - Clean Water");
                    Console.WriteLine("5 - Machete");
                    Console.WriteLine("6 - Canoe");
                    Console.WriteLine("7 - Food Supplies");
                    Console.Write("What number do you want to see the price of? ");
                    homework.ItemChoice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 3)
                    {
                        Console.Write("Enter your name: ");
                        homework.UserName = Console.ReadLine();
                        Console.WriteLine(homework.GetDiscountedPrice());
                    }
                    else
                    {
                        Console.WriteLine(homework.GetItemPrice());
                    }
                    break;
                case 4:// The Prototype
                    int targetNumber;
                    do
                    {
                        Console.Write("User 1, enter a number between 0 and 100: ");
                        targetNumber = Convert.ToInt32(Console.ReadLine());
                    } while (targetNumber < 0 || targetNumber > 100);
                    Console.Clear();
                    int guess;
                    do
                    {
                        Console.Write("User 2, guess the number: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if (guess > targetNumber)
                            Console.WriteLine("Too high!");
                        else if (guess < targetNumber)
                            Console.WriteLine("Too low!");
                    } while (guess != targetNumber);
                    Console.WriteLine("You guessed the number!");
                    break;
                case 5:// The Magic Cannon
                    for (int i = 1; i <= 100; i++)
                    {
                        string blastType = "Normal";
                        ConsoleColor color = ConsoleColor.Gray; // Default color

                        if (i % 15 == 0)
                        {
                            blastType = "Fire & Electric";
                            color = ConsoleColor.Blue; // Combined blast - Blue
                        }
                        else if (i % 3 == 0)
                        {
                            blastType = "Fire";
                            color = ConsoleColor.Red; // Fire - Red
                        }
                        else if (i % 5 == 0)
                        {
                            blastType = "Electric";
                            color = ConsoleColor.Yellow; // Electric - Yellow
                        }

                        Console.ForegroundColor = color; 
                        Console.WriteLine($"{i}: {blastType}");
                        Console.ResetColor(); // Reset to default color
                    }
                    break;

                case 6:// The Replicator of D'To
                    int[] originalArray = new int[5];
                    int[] copiedArray = new int[5];
                    Console.WriteLine("Enter 5 numbers:");
                    for (int i = 0; i < 5; i++)
                    {
                        originalArray[i] = Convert.ToInt32(Console.ReadLine());
                        copiedArray[i] = originalArray[i];
                    }
                    Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
                    Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));
                    /*int[] originalArray = new int[5];
                    int[] copiedArray = new int[5];

                    Console.WriteLine("Enter 5 numbers:");
                     for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Enter number {i + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            originalArray[i] = number;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            return; // Or handle the error differently
                        }
                    }

                    // Replication (copying)
                    for (int i = 0; i < 5; i++)
                    {
                        copiedArray[i] = originalArray[i];
                    }

                    Console.WriteLine("Original Array: " + string.Join(", ", originalArray)); // Using string.Join
                    Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));     // Using string.Join

                    // Or, if you want to display one element at a time:
                    //Console.WriteLine("\nOriginal Array (one by one):");
                    //for (int i = 0; i < 5; i++) {
                    //    Console.WriteLine(originalArray[i]);
                    //}
                    //Console.WriteLine("\nCopied Array (one by one):");
                    //for (int i = 0; i < 5; i++) {
                    //    Console.WriteLine(copiedArray[i]);
                    //} */
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 6.");
                    break;
            }
        }
    }
}
