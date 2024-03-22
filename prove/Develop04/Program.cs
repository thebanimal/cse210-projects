using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        
        activity1.Run();
    }
}