class OutdoorGathering : Event {
    public string weatherForecast;

    public override string _getFullDetails() {
        return $"{base._getFullDetails()}. Weather forecast: {weatherForecast}";
    }
}