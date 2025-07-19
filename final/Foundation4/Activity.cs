class Activity
{
    private string date;
    private int minutes;

    public void SetDate(string d) { date = d; }
    public string GetDate() { return date; }

    public void SetMinutes(int m) { minutes = m; }
    public int GetMinutes() { return minutes; }

    public virtual double GetDistance() { return 0; }

    public virtual double GetSpeed() { return 0; }

    public virtual double GetPace() { return 0; }

    public virtual string GetSummary()
    {
        return $"{date} Activity ({minutes} min)";
    }
}