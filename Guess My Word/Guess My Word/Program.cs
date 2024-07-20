using System.Threading.Tasks.Dataflow;

class Guess
{
    string[] categories = { "Movies", "Books", "Animals" };
    string[,] Words = { { "Batman", "Casablanca", "Fantastic Beasts", "A Quiet Place", "The Garfield Movie" }, { "Fourth Wing", "The Midnight Feast", "Ender's Game", "Throne of Glass", "Divergent" }, { "Horse", "Pig", "Unicorn", "Dog", "Cat" } };
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Guess guess = new Guess();

        int randomCategory = rnd.Next(0, guess.categories.Length);
        int randomWord = rnd.Next(0, guess.Words.GetLength(1));

        string selectedWord = guess.Words[randomCategory, randomWord];

        Console.WriteLine($"Category: {guess.categories[randomCategory]}");
        Console.WriteLine("Enter Word: ");
        string userInput = Console.ReadLine();
    }
}