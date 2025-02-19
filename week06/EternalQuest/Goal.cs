using System.Globalization;
using System.Text.Json.Serialization;

public abstract class Goal
{
  private string _shortName;
  private string _description;
  private int _points;
  private int _earnedPoints;

  public Goal(string name, string description, int points)
  {
    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
    string titleCase = textInfo.ToTitleCase(name);
    _shortName = titleCase;
    _description = description;
    _points = points;
    _earnedPoints = 0;
  }

  public string Name
  {
    get { return _shortName; }
    set
    {
      TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
      string titleCase = textInfo.ToTitleCase(value);
      _shortName = titleCase;
    }
  }

  public string Description
  {
    get { return _description; }
    set { _description = value; }
  }

  public int Points
  {
    get { return _points; }
    set { _points = value; }
  }
  public int EarnedPoints
  {
    get { return _earnedPoints; }
    set { _earnedPoints = value; }
  }

  public abstract void RecordEvent();

  public abstract bool IsCompleted();

  public abstract string GetStringRepresentation();

  public virtual string GetDetailsString()
  {
    string isCompleted = IsCompleted() ? "X" : " ";
    return $"[{isCompleted}] {_shortName} ({_description})";
  }
}