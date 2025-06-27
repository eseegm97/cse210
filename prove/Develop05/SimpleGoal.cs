class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points)
        : base(title, description, points) { }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool IsCompleted() => _isCompleted;

    public override string Display()
    {
        return $"[{(_isCompleted ? "X" : " ")}] {_title} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_title}|{_description}|{_points}|{_isCompleted}";
    }
}