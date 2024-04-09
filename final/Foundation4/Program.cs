using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];

        RunningActivity activity1 = new RunningActivity("03 Nov 2022", 30, 3);
        activities.Add(activity1);

        CyclingActivity activity2 = new CyclingActivity("29 May 2024", 45, 12);
        activities.Add(activity2);

        SwimmingActivity activity3 = new SwimmingActivity("03 July 2024", 15, 20);
        activities.Add(activity3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}