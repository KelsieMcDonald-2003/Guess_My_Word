using System;
using System.Diagnostics.Tracing;

class Guess
{
    string[] categories = { "Movies", "Books", "Animals" };
    string[,] words = {
        { "Batman", "Casablanca", "Fantastic Beasts", "A Quiet Place", "The Garfield Movie" },
        { "Fourth Wing", "The Midnight Feast", "Ender's Game", "Throne of Glass", "Divergent" },
        { "Horse", "Pig", "Unicorn", "Dog", "Cat" }
    };

    public static void Main()
    {
        Console.WriteLine("Enter the number for the mode you desire: ");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Normal");
        Console.WriteLine("3. Hard");
        int level;
        Console.Write("Enter your choice: ");
        level = int.Parse(Console.ReadLine());

        switch (level)
        {
            case 1:
                EasyMode();
                break;
            case 2:
                NormalMode();
                break;
            case 3:
                HardMode();
                break;
        }
    }

    public static (int randomCategory, int randomWord) RandomizeChoice()
    {
        Random rnd = new Random();
        Guess guess = new Guess();

        int randomCategory = rnd.Next(0, guess.categories.Length);
        int randomWord = rnd.Next(0, guess.words.GetLength(1));

        return (randomCategory, randomWord);
    }

    public static void EasyMode()
    {
        int tries = 7;
        int attempt = 0;

        var result = RandomizeChoice();
        Guess guess = new Guess();

        string category = guess.categories[result.randomCategory];
        string word = guess.words[result.randomCategory, result.randomWord];
        while (tries != 0)
        {
            foreach (char letter in word)
            {
                Console.Write('_');
            }
            Console.WriteLine();
            Console.WriteLine($"Category: {category}");
            Console.WriteLine("Enter your guess: ");
            var userChoice = Console.ReadLine();

            if (userChoice == word)
            {
                attempt++;
                Console.Write($"Congrats! You guessed the word! It was: {word}. ");
                Console.Write($"It took you {attempt} tries");
                break;
            }
            else if (string.IsNullOrEmpty(userChoice))
            {
                Console.WriteLine($"You did not enter a word. Please enter a word. The category is: {category}");
            }
            else
            {
                tries--;
                attempt++;
                Console.WriteLine($"Incorrect. Category: {category} Tries left: {tries}");
            }
        }
    }

    public static void NormalMode()
    {
        int tries = 5;
        int attempt = 0;

        var result = RandomizeChoice();
        Guess guess = new Guess();

        string category = guess.categories[result.randomCategory];
        string word = guess.words[result.randomCategory, result.randomWord];

        while (tries != 0)
        {
            foreach (char letter in word)
            {
                Console.Write('_');
            }
            Console.WriteLine();
            Console.WriteLine($"Category: {category}");
            Console.WriteLine("Enter a word: ");
            var userChoice = Console.ReadLine();

            if (userChoice == word)
            {
                attempt++;
                Console.Write($"Congrats! You guessed the word! It was: {word}. ");
                Console.Write($"It took you {attempt} tries");
                break;
            }
            else if (string.IsNullOrEmpty(userChoice))
            {
                Console.WriteLine($"You did not enter a word. Please enter a word. The category is: {category}");
            }
            else
            {
                tries--;
                attempt++;
                Console.WriteLine($"Incorrect. Category: {category} Tries left: {tries}");
            }
        }
    }

    public static void HardMode()
    {
        int tries = 3;
        int attempt = 0;

        var result = RandomizeChoice();
        Guess guess = new Guess();

        string category = guess.categories[result.randomCategory];
        string word = guess.words[result.randomCategory, result.randomWord];

        while (tries != 0)
        {
            foreach (char letter in word)
            {
                Console.Write('_');
            }
            Console.WriteLine();
            Console.WriteLine($"Category: {category}");
            Console.WriteLine("Enter a word: ");
            var userChoice = Console.ReadLine();

            if (userChoice == word)
            {
                attempt++;
                Console.Write($"Congrats! You guessed the word! It was: {word}. ");
                Console.Write($"It took you {attempt} tries");
                break;
            }
            else if (string.IsNullOrEmpty(userChoice))
            {
                attempt++;
                Console.WriteLine($"You did not enter a word. Please enter a word. The category is: {category}");
            }
            else
            {
                attempt++;
                tries--;
                Console.WriteLine($"Incorrect. Category: {category} Tries left: {tries}");
            }
        }
    }
}

