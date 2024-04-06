using System;

class Program
{
    static void Main(string[] args)
    {
        // I used real videos and comments from my family's YouTube channel: Reeds on the Road
        List<Video> videos = [];

        Video intro = new Video("Name Our Ride!", "Reeds on the Road", 179);
        Comment comment1 = new Comment("hepcatblm", "The Reedinator");
        intro.AddComment(comment1);
        Comment comment2 = new Comment("charleshendricks8639", "The Reed-Russler?");
        intro.AddComment(comment2);
        Comment comment3 = new Comment("RogerWilco1", "Who built this rig?  I've never seen one like it.");
        intro.AddComment(comment3);
        videos.Add(intro);

        Video temple = new Video("Seattle, WA Temple", "Reeds on the Road", 74);
        Comment comment4 = new Comment("goblincamper2004", "My wife and I will be visiting Seattle for a few short days from the 18-20th of August and we plan to drive by the Seattle Temple while we are there. We are from St. George, Utah and so we have two Temples nearby, but St. George Temple is currently under renovation and the Red Cliffs Utah is currently being constructed. So the closest operating temple to us is Cedar City Temple.");
        temple.AddComment(comment4);
        Comment comment5 = new Comment("robertferrin4480", "I was just an infant when my took me for the open house.");
        temple.AddComment(comment5);
        Comment comment6 = new Comment("reedsontheroad4061", "https://www.churchofjesuschrist.org/temples/details/seattle-washington-temple?lang=eng");
        temple.AddComment(comment6);
        videos.Add(temple);

        Video service = new Video("Center for Wildlife", "Reeds on the Road", 330);
        videos.Add(service);

        Video missionaries = new Video("Missionaries!", "Reeds on the Road", 274);
        Comment comment7 = new Comment("themikedropshow4348", "Thanks for this video!");
        missionaries.AddComment(comment7);
        Comment comment8 = new Comment("deborahhalpenny4635", "Welcome home!!");
        missionaries.AddComment(comment8);
        Comment comment9 = new Comment("reedsontheroad4061", "Thank you!");
        missionaries.AddComment(comment9);
        videos.Add(missionaries);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}