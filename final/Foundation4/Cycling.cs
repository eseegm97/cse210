class Cycling : Activity
{
    private double speed;

    public void _setSpeed(double s) { speed = s; }

    public override double _getDistance()
    {
        return speed * (_getMinutes() / 60.0);
    }

    public override double _getSpeed()
    {
        return speed;
    }

    public override double _getPace()
    {
        return 60 / speed;
    }

    public override string _getSummary()
    {
        return $"{_getDate()} Cycling ({_getMinutes()} min): Distance {_getDistance():F2} km, Speed {_getSpeed():F2} kph, Pace: {_getPace():F2} min per km";
    }
}