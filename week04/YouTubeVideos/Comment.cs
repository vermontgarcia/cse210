public class Comment
{
  private string _name;
  private string _comment;
  private DateTime _timeStamp;

  public Comment(string name, string comment)
  {
    _name = name;
    _comment = comment;
    _timeStamp = DateTime.UtcNow;
  }

  public string GetUserName()
  {
    return _name;
  }

  public string GetUserNComment()
  {
    return _comment;
  }

  public string GetCommentTextString()
  {
    return $"{_timeStamp}: {_name} - {_comment}";
  }
}
