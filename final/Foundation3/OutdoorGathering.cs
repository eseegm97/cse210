class OutdoorGathering : Event {
    public string weatherForecast;

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}. Weather forecast: {weatherForecast}";
    }
}