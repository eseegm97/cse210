class Lecture : Event {
    public string speakerName;
    public int capacity;

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}. Speaker: {speakerName}, Capacity: {capacity}";
    }
}