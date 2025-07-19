class Running : Activity
{
    private double distance;

    public void SetDistance(double d) { distance = d; }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (GetMinutes() / 60.0);
    }

    public override double GetPace()
    {
        return GetMinutes() / distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}