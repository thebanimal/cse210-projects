using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Fake Street", "False City", "California", "USA");
        LectureEvent event1 = new LectureEvent("Interesting Topics", "Come listen as we discuss several facinating topics.", "May 29, 2024", "5pm", address1, "John Smith", 150);
        event1.CreateStandardDetails();
        Console.WriteLine("");
        event1.CreateFullDetails();
        Console.WriteLine("");
        event1.CreateShortDetails();
        Console.WriteLine("");

        Address address2 = new Address("321 Untrue Street", "Counterfeit Town", "Alberta", "CAN");
        ReceptionEvent event2 = new ReceptionEvent("Jane and Dave's Wedding", "Celebrate the wonderful union between two wonderful people", "July 3, 2024", "3pm", address2, "fakeemail@gmail.com");
        event2.CreateStandardDetails();
        Console.WriteLine("");
        event2.CreateFullDetails();
        Console.WriteLine("");
        event2.CreateShortDetails();
        Console.WriteLine("");

        Address address3 = new Address("Forgery Park", "Sham", "Chihuahua", "MEX");
        OutdoorEvent event3 = new OutdoorEvent("Cinco de Mayo Picnic", "Community lunch to celebrate the Cinco de Mayo", "May 5, 2024", "12pm", address3, "Sunny");
        event3.CreateStandardDetails();
        Console.WriteLine("");
        event3.CreateFullDetails();
        Console.WriteLine("");
        event3.CreateShortDetails();
        Console.WriteLine("");
    }
}