public class Video
{
  private string _title;
  private string _author;
  private int _length;
  private List<Comment> _comments;

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
    _comments = [];
  }

  public int GetCommnetsNumber()
  {
    return _comments.Count;
  }

  public string GetVideoInfo()
  {
    return $"Title: {_title} - Author: {_author} - {_length} sec - {GetCommnetsNumber()} comments";
  }

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }

  public List<string> GetComments()
  {
    List<string> comments = [];
    foreach (Comment comment in _comments)
    {
      comments.Add(comment.GetCommentTextString());
    }
    return comments;
  }
}
