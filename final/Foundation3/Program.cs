using System;

class Program {
    static void Main(string[] args) {
        Address addr = new Address() {
            street = "456 Park Ave",
            city = "Metropolis",
            stateOrProvince = "NY",
            country = "USA"
        };

        Lecture lecture = new Lecture() {
            title = "Lecture: Understanding Homer's Odyssey",
            description = "A lecture on the themes of Homer's Odyssey",
            date = "2025-08-01",
            time = "10:00 AM",
            address = addr,
            speakerName = "Dr. Smith",
            capacity = 50
        };

        Reception reception = new Reception() {
            title = "McMaynerbury Wedding Reception",
            description = "Celebration of the wedding of Mr. and Mrs. McMaynerbury",
            date = "2025-08-01",
            time = "3:00 PM",
            address = addr,
            rsvpEmail = "rsvp@example.com"
        };

        OutdoorGathering gathering = new OutdoorGathering() {
            title = "Picnic",
            description = "Community picnic in the park",
            date = "2025-08-02",
            time = "11:30 PM",
            address = addr,
            weatherForecast = "Sunny"
        };

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(gathering.GetFullDetails());
    }
}