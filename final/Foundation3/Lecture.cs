class Lecture : Event {
    public string speakerName;
    public int capacity;

    public override string _getFullDetails() {
        return $"{base._getFullDetails()}. Speaker: {speakerName}, Capacity: {capacity}";
    }
}