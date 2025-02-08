using System;
using System.Text.RegularExpressions;

public partial class Word
{
  private string _word;
  private bool _isHidden;

  public Word(string word)
  {
    _word = word;
    _isHidden = false;
  }

  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }

  public string GetDisplayText()
  {
    if (_isHidden)
    {
      string hiddenWord = WordRegex().Replace(_word, "_");
      return hiddenWord;
    }
    else
    {
      return _word;
    }
  }
  
  [GeneratedRegex("[a-zA-Z]")]
  private static partial Regex WordRegex();
}