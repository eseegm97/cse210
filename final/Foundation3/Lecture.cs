class Lecture : Event {
    public string _speakerName;
    public int _capacity;

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}. Speaker: {_speakerName}, Capacity: {_capacity}";
    }
}