class Running : Activity
{
    private double distance;

    public void _setDistance(double d) { distance = d; }

    public override double _getDistance()
    {
        return distance;
    }

    public override double _getSpeed()
    {
        return distance / (_getMinutes() / 60.0);
    }

    public override double _getPace()
    {
        return _getMinutes() / distance;
    }

    public override string _getSummary()
    {
        return $"{_getDate()} Running ({_getMinutes()} min): Distance {_getDistance():F2} km, Speed {_getSpeed():F2} kph, Pace: {_getPace():F2} min per km";
    }
}