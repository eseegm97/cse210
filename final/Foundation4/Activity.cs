class Activity
{
    private string date;
    private int minutes;

    public void _setDate(string d) { date = d; }
    public string _getDate() { return date; }

    public void _setMinutes(int m) { minutes = m; }
    public int _getMinutes() { return minutes; }

    public virtual double _getDistance() { return 0; }

    public virtual double _getSpeed() { return 0; }

    public virtual double _getPace() { return 0; }

    public virtual string _getSummary()
    {
        return $"{date} Activity ({minutes} min)";
    }
}