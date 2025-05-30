using System;

class Program
{
    static void Main(string[] args)
    {
        Reference[] references = new Reference[]
        {
            new Reference("John", 3, 16),
            new Reference("Proverbs", 3, 5, 6),
            new Reference("Psalm", 23, 1),
            new Reference("2 Nephi", 2, 25),
            new Reference("Mosiah", 2, 17)
        };

        string[] texts = new string[]
        {
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.",
            "The Lord is my shepherd; I shall not want.",
            "Adam fell that men might be; and men are, that they might have joy.",
            "When ye are in the service of your fellow beings ye are only in the service of your God."
        };

        Random rand = new Random();
        bool tryAgain = true;

        while (tryAgain)
        {
            int index = rand.Next(references.Length);
            Reference reference = references[index];
            string text = texts[index];

            Scripture scripture = new Scripture(reference, text);

            while (!scripture.AllWordsHidden())
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

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        return _endVerse == null
            ? $"{_book} {_chapter}:{_startVerse}"
            : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public bool IsVisible()
    {
        return !_isHidden;
    }
}

class Scripture
{
    private Reference _reference;
    private Word[] _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordStrings = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        _words = new Word[wordStrings.Length];
        for (int i = 0; i < wordStrings.Length; i++)
        {
            _words[i] = new Word(wordStrings[i]);
        }
        _random = new Random();
    }

    public void HideRandomWords(int count)
    {
        int[] visibleIndexes = new int[_words.Length];
        int visibleCount = 0;
        for (int i = 0; i < _words.Length; i++)
        {
            if (_words[i].IsVisible())
            {
                visibleIndexes[visibleCount++] = i;
            }
        }

        for (int i = 0; i < count && visibleCount > 0; i++)
        {
            int randIndex = _random.Next(visibleCount);
            int wordIndex = visibleIndexes[randIndex];
            _words[wordIndex].Hide();
            visibleIndexes[randIndex] = visibleIndexes[--visibleCount];
        }
    }

    public bool AllWordsHidden()
    {
        for (int i = 0; i < _words.Length; i++)
        {
            if (_words[i].IsVisible())
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string output = _reference.ToString() + "\n\n";
        for (int i = 0; i < _words.Length; i++)
        {
            output += _words[i].GetDisplayText();
            if (i < _words.Length - 1)
                output += " ";
        }
        return output;
    }
}