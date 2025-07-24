class OutdoorGathering : Event {
    public string _weatherForecast;

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}. Weather forecast: {_weatherForecast}";
    }
}