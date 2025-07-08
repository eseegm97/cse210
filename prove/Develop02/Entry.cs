using System;

public class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string GetFormattedEntry()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

    public string ToFileFormat()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[1], parts[2], parts[0]);
        }
        return null;
    }
}