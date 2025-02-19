using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("ExerciseTracking Project.");

        Console.WriteLine();
        Running running = new(30, 5);
        Cycling cycling = new(23, 18.3);
        Swimming swimming = new(50, 42);

        List<Activity> activities = [running, cycling, swimming];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}
