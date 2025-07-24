using System;

class Program {
    static void Main(string[] args) {
        Address addr = new Address() {
            _street = "456 Park Ave",
            _city = "Metropolis",
            _stateOrProvince = "NY",
            _country = "USA"
        };

        Lecture lecture = new Lecture() {
            _title = "Lecture: Understanding Homer's Odyssey",
            _description = "A lecture on the themes of Homer's Odyssey",
            _date = "2025-08-01",
            _time = "10:00 AM",
            _address = addr,
            _speakerName = "Dr. Smith",
            _capacity = 50
        };

        Reception reception = new Reception() {
            _title = "McMaynerbury Wedding Reception",
            _description = "Celebration of the wedding of Mr. and Mrs. McMaynerbury",
            _date = "2025-08-01",
            _time = "3:00 PM",
            _address = addr,
            _rsvpEmail = "rsvp@example.com"
        };

        OutdoorGathering gathering = new OutdoorGathering() {
            _title = "Picnic",
            _description = "Community picnic in the park",
            _date = "2025-08-02",
            _time = "11:30 PM",
            _address = addr,
            _weatherForecast = "Sunny"
        };

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(gathering.GetFullDetails());
    }
}