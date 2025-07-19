class Swimming : Activity
{
    private int laps;

    public void _setLaps(int l) { laps = l; }

    public override double _getDistance()
    {
        return laps * 0.05;
    }

    public override double _getSpeed()
    {
        return _getDistance() / (_getMinutes() / 60.0);
    }

    public override double _getPace()
    {
        return _getMinutes() / _getDistance();
    }

    public override string _getSummary()
    {
        return $"{_getDate()} Swimming ({_getMinutes()} min): Distance {_getDistance():F2} km, Speed {_getSpeed():F2} kph, Pace: {_getPace():F2} min per km";
    }
}