class Event {
    public string title;
    public string description;
    public string date;
    public string time;
    public Address address;

    public string _getStandardDetails() {
        return $"{title} on {date} at {time}";
    }

    public virtual string _getFullDetails() {
        return $"{_getStandardDetails()}, located at {address._getFullAddress()}";
    }

    public string _getShortDescription() {
        return $"{title}: {description}";
    }
}