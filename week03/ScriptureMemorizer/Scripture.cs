public class Scripture
{
  private Reference _reference;
  private List<Word> _scriptureText = [];

  public Scripture(Reference reference, string text)
  {
    _reference = reference;

    List<string> wordsText = text.Split(" ").ToList();
    foreach (string word in wordsText)
    {
      Word newWord = new(word);
      _scriptureText.Add(newWord);
    }
  }

  public string GetDisplayText()
  {
    List<string> textList = [_reference.GetDisplayText()];
    foreach (Word word in _scriptureText)
    {
      textList.Add(word.GetDisplayText());
    }
    return string.Join(" ", textList);
  }

  public bool AreAllWordsHidden()
  {
    return _scriptureText.All(word => word.IsHidden());
  }

  public void HideRandomWords(int numberToHide)
  // Exceeding Requirements
  // Hide random words, It validates if the word is already hidden.
  // Choose a different to hide if already hidden  
  {
    Console.WriteLine(numberToHide);
    Random _random = new Random();

    for (int i = 1; i <= numberToHide; i++)
    {
      do
      {
        if (!AreAllWordsHidden())
        {
          int randomIndex = _random.Next(_scriptureText.Count);
          if (_scriptureText[randomIndex].IsHidden())
          {
            // Hidden already
            continue;
          }
          else
          {
            // Not hidden, proceed to hide
            _scriptureText[randomIndex].Hide();
            break;
          }
        }
        else
        {
          // Nothning else to hide, breack do-while loop and force for loop to finish
          i = numberToHide;
          break;
        }
      } while (true);
    }
  }
}