using System;

class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int points = _goals[goalIndex].RecordEvent();
            _totalScore += points;

            Console.WriteLine($"Event recorded! You gained {points} points.");
            if (_goals[goalIndex].IsCompleted())
                Console.WriteLine("Congratulations! You completed a goal!");
        }
    }

    public string ShowGoals()
    {
        string output = "";
        for (int i = 0; i < _goals.Count; i++)
        {
            output += $"{i + 1}. {_goals[i].Display()}\n";
        }
        return output;
    }

    public int GetScore() => _totalScore;

    public void Save()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void Load()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _totalScore = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4])) sg.RecordEvent();
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                     int.Parse(parts[5]), int.Parse(parts[6]));
                for (int j = 0; j < int.Parse(parts[4]); j++) cg.RecordEvent();
                _goals.Add(cg);
            }
        }

        Console.WriteLine("Goals loaded!");
    }
}