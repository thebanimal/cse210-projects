using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        List<string> reflectingPrompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        List<string> reflectingQuestions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", reflectingPrompts, reflectingQuestions);

        List<string> listingPrompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingPrompts);
        
        int choice;
        int i = 0;
        DateTime startActivities = DateTime.Now;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                activity1.Run();
                i++;
            }
            else if (choice == 2)
            {
                activity2.Run();
                i++;
            }
            else if (choice == 3)
            {
                activity3.Run();
                i++;
            }
        } while (choice != 4);

        TimeSpan timespan = DateTime.Now - startActivities;
        int seconds = (int)timespan.TotalSeconds;
        
        Console.WriteLine("");
        Console.WriteLine("Thank you for participating.");
        Console.WriteLine($"You completed {i} activities.");
        Console.WriteLine($"It took you {seconds} seconds.");
    }
}