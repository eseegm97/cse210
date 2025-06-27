class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points)
        : base(title, description, points) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsCompleted() => false;

    public override string Display()
    {
        return $"[∞] {_title} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_title}|{_description}|{_points}";
    }
}