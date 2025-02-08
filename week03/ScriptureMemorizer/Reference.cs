public class Reference
{
  private string _book;
  private int _chapter;
  private int _initialVerse;
  private int _endVerse;

  public Reference(string book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _initialVerse = verse;
  }

  public Reference(string book, int chapter, int verse, int endVerse)
  {
    _book = book;
    _chapter = chapter;
    _initialVerse = verse;
    _endVerse = endVerse;
  }

  public string GetDisplayText()
  {
    if (_endVerse > 0)
    {
      return $"{_book} {_chapter}:{_initialVerse}-{_endVerse}";
    }
    else
    {
      return $"{_book} {_chapter}:{_initialVerse}";
    }
  }
}