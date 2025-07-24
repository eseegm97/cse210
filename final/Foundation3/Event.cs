class Event {
    public string _title;
    public string _description;
    public string _date;
    public string _time;
    public Address _address;

    public string GetStandardDetails() {
        return $"{_title} on {_date} at {_time}";
    }

    public virtual string GetFullDetails() {
        return $"{GetStandardDetails()}, located at {_address.GetFullAddress()}";
    }

    public string GetShortDescription() {
        return $"{_title}: {_description}";
    }
}