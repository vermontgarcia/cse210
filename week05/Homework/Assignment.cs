public class Assignment
{
  private string _studentName;
  private string _topic;

  public Assignment(string studentName, string topic)
  {
    _studentName = studentName;
    _topic = topic;
  }

  public string StudentName
  {
    get
    {
      return _studentName;
    }
  }

  public string GetSummary()
  {
    return $"{_studentName} - {_topic}";
  }
}
