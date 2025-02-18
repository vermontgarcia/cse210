public class ReflectingActivity : Activity
{
  private readonly List<string> _prompts;
  private List<string> _questions = [];
  private static readonly Random _random = new Random();

  public ReflectingActivity(string name, string description) : base(name, description)
  {
    _prompts = [
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless.",
    ];
  }

  public void InitializeQuestions()
  // Exceeding Requirements Initialize questions every time the activity is running
  {
    _questions = [
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?",
    ];
  }

  private string GetRandomPrompt()
  {
    int randomIndex = _random.Next(_prompts.Count);
    return _prompts[randomIndex];
  }

  private string GetRandomQuestion()
  // Exceeding Requirements: Remove question from the list to prevent displaying repeated question
  {
    if (_questions.Count == 0)
    {
      InitializeQuestions();
    }

    int randomIndex = _random.Next(_questions.Count);
    string selectedQuestion = _questions[randomIndex];
    _questions.RemoveAt(randomIndex);

    return selectedQuestion;
  }

  private void DisplayPrompt()
  {
    string selectedPrompt = GetRandomPrompt();
    Console.WriteLine();
    Console.WriteLine("Consider the followiong prompt:");
    Console.WriteLine();
    Console.WriteLine($">>> {selectedPrompt} <<<");
    Console.WriteLine();
    Console.Write("When you have somethning in mind, press enter to continue...");
    Console.ReadLine();
  }

  private void DisplayQuestions()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(base.Duration);
    while (DateTime.Now < endTime)
    {
      Console.WriteLine();
      Console.Write($"{GetRandomQuestion()} ");
      ShowSpinner(8);
    }
    Console.WriteLine();
  }

  public void StartActivity()
  {
    base.DisplayStartingMessage();
    base.SetActivityDuration(30);
    Console.Clear();
    GetReady();
    Console.WriteLine();

    DisplayPrompt();
    DisplayQuestions();

    WellDone();
    DisplayEndingMessage();
    InitializeQuestions();
    Console.Clear();
  }
}