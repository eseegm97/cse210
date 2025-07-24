class Reception : Event {
    public string _rsvpEmail;

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}. RSVP at: {_rsvpEmail}";
    }
}