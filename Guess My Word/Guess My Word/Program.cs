using System.Threading.Tasks.Dataflow;

class Guess
{
    string[] categories = { "Movies", "Books", "Animals" };
    string[,] words = { { "Batman", "Casablanca", "Fantastic Beasts", "A Quiet Place", "The Garfield Movie" }, { "Fourth Wing", "The Midnight Feast", "Ender's Game", "Throne of Glass", "Divergent" }, { "Horse", "Pig", "Unicorn", "Dog", "Cat" } };

    public static void Main()
    {
        var result = RandomizeChoice();
        Guess guess = new Guess();

        string category = guess.categories[result.randomCategory];
        string word = guess.words[result.randomCategory, result.randomWord];

        Console.WriteLine($"Category: {category}");
        Console.WriteLine("Enter your guess: ");
        var userChoice = Console.ReadLine();

        while(string.IsNullOrEmpty(userChoice))
        {
            Console.WriteLine("You did not enter a word. Please enter your guess: ");
            userChoice = Console.ReadLine();
        }

        if(userChoice == word)
        {
            Console.Write("Congrats! You guessed my word!");
        }
        else
        {
            Console.WriteLine("I'm sorry, but that is incorrect.");
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
}