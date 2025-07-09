using System;

class Scripture
{
    private Reference _reference;
    private Word[] _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordStrings = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        _words = Array.ConvertAll(wordStrings, word => new Word(word));
    }

    public bool AreAllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (word.IsVisible())
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        var result = _reference.ToString() + "\n\n";
        foreach (var word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.TrimEnd();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = new List<Word>();
        foreach (var word in _words)
        {
            if (word.IsVisible())
                visibleWords.Add(word);
        }

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public void ResetWords()
    {
        foreach (var word in _words)
        {
            word.Show();
        }
    }
}