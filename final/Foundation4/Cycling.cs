class Cycling : Activity
{
    private double speed;

    public void SetSpeed(double s) { speed = s; }

    public override double GetDistance()
    {
        return speed * (GetMinutes() / 60.0);
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}