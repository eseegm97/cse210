class Activity
{
    private string _date;
    private int _minutes;

    public void SetDate(string d) { _date = d; }
    public string GetDate() { return _date; }

    public void SetMinutes(int m) { _minutes = m; }
    public int GetMinutes() { return _minutes; }

    public virtual double GetDistance() { return 0; }

    public virtual double GetSpeed() { return 0; }

    public virtual double GetPace() { return 0; }

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_minutes} min)";
    }
}