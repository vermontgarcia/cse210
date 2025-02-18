
using System.Globalization;

public class Activity
{
  private string _name;
  private string _description;
  private int _duration = 0;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }

  public int Duration
  {
    get
    {
      return _duration;
    }
  }

  public void DisplayStartingMessage()
  {
    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
    string titleCase = textInfo.ToTitleCase(_name);

    string welcomeMessage = $"\nWelcome to the {titleCase}\n";

    Console.WriteLine(welcomeMessage);
    Console.WriteLine($"{_description}\n");
  }

  public string GetEndingMessage()
  {
    return $"You have completed {_duration} seconds of the {_name}";
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine(GetEndingMessage());
    ShowSpinner(6);
  }

  public static void ShowSpinner(int duration)
  {
    List<string> spiner = ["| ", "/ ", "- ", "\\ "];
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    int i = 0;

    while (DateTime.Now < endTime)
    {
      string c = spiner[i];
      Console.Write(c);
      Thread.Sleep(500);
      Console.Write("\b\b  \b\b");

      i++;
      if (i == spiner.Count)
      {
        i = 0;
      }
    }
  }

  public static void ShowCountDown(int duration)
  {
    for (int i = duration; i > 0; i--)
    {
      Console.Write($"{i} ");
      Thread.Sleep(1000);
      Console.Write("\b\b  \b\b");
    }
  }

  public void SetActivityDuration(int minDuration)
  {
    int duration = 0;
    do
    {
      Console.Write("How long (in seconds) would you like for your session? ");
      try
      {
        duration = int.Parse(Console.ReadLine());
        if (duration < minDuration)
        {
          Console.WriteLine($"Activity duration must be at least {minDuration} seconds");
          duration = 0;
        }
      }
      catch (FormatException)
      {
        Console.WriteLine("Please enter a valid duration");
      }
    } while (duration == 0);
    _duration = duration;
  }

  public static void GetReady()
  {
    Console.Write("Get ready to start... ");
    ShowSpinner(6);
  }

  public static void WellDone()
  {
    Console.WriteLine();
    Console.WriteLine("Good job!!");
    ShowSpinner(6);
  }
}