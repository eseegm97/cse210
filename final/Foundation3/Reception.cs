class Reception : Event {
    public string rsvpEmail;

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}. RSVP at: {rsvpEmail}";
    }
}