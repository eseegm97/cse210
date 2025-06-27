using System;

abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public abstract int RecordEvent();
    public abstract bool IsCompleted();
    public abstract string Display();
    public abstract string GetStringRepresentation();
}