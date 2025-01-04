using System;
using System.Collections.Generic;

class Program
{
    // Sayı tahmin metodu
    static int GuessNumber()
    {
        Console.Write("Please insert a number: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        return guess;
    }

    static void Main()
    {
        Console.WriteLine("Hello!\nWelcome to Guess The Number.\nYou will try to guess a random number between 1 and 100. You will have 5 chances to do so. After each guess, you will be given a hint. If you're ready, let's begin! (y/n)");

        string choice = Console.ReadLine();

        if (choice == "y" || choice == "n")
        {
            if (choice == "n")
            {
                Console.WriteLine("Actually, you have no choice :) Let's start the game!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Let's go then!");
                Console.ReadKey();
            }

            Console.Clear();

            int counter = 5;
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            List<int> previousGuesses = new List<int>(); //Önceki tahminleri de görmek istediğim için eklediğim kod bloğu

            while (counter > 0)
            {
                int guess = GuessNumber();
                previousGuesses.Add(guess);

                if (guess == number)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Görsel olarak daha güzel olması için bulduğum fon ayarı
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine($"Congratulations! Your guess is: {guess}. The number is: {number}");
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    // Alt ve üst sınır hesaplamaları ve ipucu
                    int lowerBound = Math.Max(1, (int)(number * 0.8)); // Doğru sayının %80'i
                    int upperBound = Math.Min(100, (int)(number * 1.2)); // Doğru sayının %120'si 100'den fazla olamaz

                    Console.ForegroundColor = ConsoleColor.Yellow; // Görsel olarak daha güzel olması için bulduğum fon ayarı
                    if (guess < number)
                    {
                        Console.WriteLine($"Your guess is too low! The number is within {lowerBound} and {upperBound}.");
                    }
                    else
                    {
                        Console.WriteLine($"Your guess is too high! The number is within {lowerBound} and {upperBound}.");
                    }
                    Console.ResetColor();

                    // Yakınlık arttıkça farklı çıktılar veren bir kod bloğu
                    int difference = Math.Abs(guess - number);
                    if (difference <= 5)
                    {
                        Console.WriteLine("You're very close!");
                    }
                    else if (difference <= 15)
                    {
                        Console.WriteLine("You're close!");
                    }
                    else if (difference <= 30)
                    {
                        Console.WriteLine("You're a bit far off.");
                    }
                    else
                    {
                        Console.WriteLine("You're way off!");
                    }
                }

                counter--;
                Console.WriteLine($"You have {counter} attempts remaining.");
                Console.WriteLine("Your previous guesses: " + string.Join(", ", previousGuesses));
            }

            //Counter 0'lanınca oyunu sonlandırır
            if (counter == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Game over! The correct number was {number}.");
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine("Please insert 'y' or 'n'.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
