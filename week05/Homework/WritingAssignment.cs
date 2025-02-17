using System.Globalization;

public class WritingAssignment : Assignment
{
  private string _title;

  public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
  {
    _title = title;
  }

  public string GetWritingInformation()
  {
    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
    string titleCase = textInfo.ToTitleCase(_title);
    return $"{titleCase} by {base.StudentName}";
  }
}
