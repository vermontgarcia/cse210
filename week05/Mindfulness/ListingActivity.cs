public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts;

  private static readonly Random _random = new Random();

  public ListingActivity(string name, string description) : base(name, description)
  {
    _prompts = [
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?",
    ];
  }

  private string GetRandomPrompt()
  {
    int randomIndex = _random.Next(_prompts.Count);
    return _prompts[randomIndex];
  }


  private void DisplayPrompt()
  {
    string selectedPrompt = GetRandomPrompt();
    Console.WriteLine();
    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine();
    Console.WriteLine($">>> {selectedPrompt} <<<");
    Console.WriteLine();
    Console.Write("You will begin in... ");
  }

  private void CountAnswers()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(base.Duration);
    Console.WriteLine();
    Console.WriteLine();
    while (DateTime.Now < endTime)
    {
      _count++;
      Console.Write($"{_count}. ");
      Console.ReadLine();
    }
    Console.WriteLine();
    string response = _count == 1 ? "response" : "responses";
    Console.WriteLine($"You have listed {_count} {response}!");
  }

  public void StartActivity()
  {
    base.DisplayStartingMessage();
    base.SetActivityDuration(20);
    Console.Clear();
    GetReady();
    Console.WriteLine();

    DisplayPrompt();
    ShowCountDown(9);
    CountAnswers();

    WellDone();
    DisplayEndingMessage();
    Console.Clear();
  }

}