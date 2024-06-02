using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("street address", "city", "country");
        DateTime date = new DateTime(2024, 06, 25, 14, 0, 0);
        string lectureEvent = "Lecture"; 
        string lectureDescription = "Programming with classes.";
        int capacity = 45; 
        int duration = 120;
        string speaker = "John Doe"; 
        string theme = "CSE210-Projects";
        string purpose = "For CSE-210 Students";
        string email = "event@rsvp.com";
        string weatherInfo = "The weather today is expected to be fair.";
        Lectures lectureOne = new Lectures(lectureEvent, lectureDescription, date, address, capacity, duration, speaker, theme, purpose);
        lectureOne.DisplayEventDetails(); 

        string receptionEvent = "Reception";
        Receptions reception = new Receptions(receptionEvent, lectureDescription, date, address, email);
        reception.DisplayEventDetails(); 

        string outdoorEvent = "Outdoor Gathering";
        OutdoorGathering outdoor = new OutdoorGathering(outdoorEvent, lectureDescription, date, address, weatherInfo);
        outdoor.DisplayEventDetails();


        

    }
}