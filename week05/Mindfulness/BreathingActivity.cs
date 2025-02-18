public class BreathingActivity : Activity
{
  public BreathingActivity(string name, string description) : base(name, description) { }

  public void StartActivity()
  {
    base.DisplayStartingMessage();
    SetActivityDuration(30);
    Console.Clear();
    GetReady();
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(base.Duration);

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

  private static void BretheIn(int duration)
  {
    Console.Write("Breathe in... ");
    ShowCountDown(duration);
    Console.WriteLine();
  }

  private static void BreatheOut(int duration)
  {
    Console.Write("Breathe out... ");
    ShowCountDown(duration);
    Console.WriteLine();
  }

}