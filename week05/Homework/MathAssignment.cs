public class MathAssignment : Assignment
{
  private string _textBookSection;
  private string _problems;
  public MathAssignment(string textBookSection, string problems, string studentName, string topic) : base(studentName, topic)
  {
    _textBookSection = textBookSection;
    _problems = problems;
  }

  public string GetHomworkList()
  {
    return $"Section {_textBookSection} Problems {_problems}";
  }
}
