public class PromptGenerator
{
  private static readonly Random _random = new Random();
  private static List<string> _prompts;

  static PromptGenerator()
  {
    _prompts = [
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?",
    ];
  }

  public string GetRandomPrompt()
  {
    int randomIndex = _random.Next(_prompts.Count);
    return _prompts[randomIndex];
  }
}
