using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture[] scriptures = new Scripture[]
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."),

            new Scripture(new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want."),

            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."),

            new Scripture(new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God.")
        };

        Random rand = new Random();
        bool tryAgain = true;

        while (tryAgain)
        {
            Scripture scripture = scriptures[rand.Next(scriptures.Length)];
            scripture.ResetWords();

            while (!scripture.AreAllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress ENTER to continue or type 'quit' to finish:");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "quit")
                    break;

                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words have been hidden or you chose to stop.");

            Console.Write("\nWould you like to try again? (yes/no): ");
            string retryInput = Console.ReadLine().Trim().ToLower();
            tryAgain = retryInput == "yes";
        }

        Console.WriteLine("\nThanks for using the Scripture Memorizer. Goodbye!");
    }
}