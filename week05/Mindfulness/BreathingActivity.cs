public class BreathingActivity : Activity
{
  public BreathingActivity(string name, string description) : base(name, description) { }

  public void StartActivity()
  {
    base.DisplayStartingMessage();
    int duration = GetActivityDuration(30);
    base.Duration = duration;
    Console.Clear();
    GetReady();
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
      Console.WriteLine();
      BretheIn(4);
      BreatheOut(6);
    }
    WellDone();
    DisplayEndingMessage();
    Console.Clear();
  }

  public static void BretheIn(int duration)
  {
    Console.Write("Breathe in... ");
    ShowCountDown(duration);
    Console.WriteLine();
  }

  public static void BreatheOut(int duration)
  {
    Console.Write("Breathe out... ");
    ShowCountDown(duration);
    Console.WriteLine();
  }

}