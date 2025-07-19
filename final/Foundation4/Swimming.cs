class Swimming : Activity
{
    private int laps;

    public void SetLaps(int l) { laps = l; }

    public override double GetDistance()
    {
        return laps * 0.05;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetMinutes() / 60.0);
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}