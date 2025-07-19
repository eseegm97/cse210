class Reception : Event {
    public string rsvpEmail;

    public override string _getFullDetails() {
        return $"{base._getFullDetails()}. RSVP at: {rsvpEmail}";
    }
}