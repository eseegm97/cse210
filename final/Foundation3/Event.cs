class Event {
    public string title;
    public string description;
    public string date;
    public string time;
    public Address address;

    public string GetStandardDetails() {
        return $"{title} on {date} at {time}";
    }

    public virtual string GetFullDetails() {
        return $"{GetStandardDetails()}, located at {address.GetFullAddress()}";
    }

    public string GetShortDescription() {
        return $"{title}: {description}";
    }
}