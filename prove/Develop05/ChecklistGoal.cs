class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int targetCount, int bonusPoints)
        : base(title, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _timesCompleted++;
            if (_timesCompleted >= _targetCount)
            {
                _isCompleted = true;
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsCompleted() => _isCompleted;

    public override string Display()
    {
        return $"[{(_isCompleted ? "X" : " ")}] {_title} ({_description}) -- Completed {_timesCompleted}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_title}|{_description}|{_points}|{_timesCompleted}|{_targetCount}|{_bonusPoints}";
    }
}