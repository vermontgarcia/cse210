using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

public class Entry
{
  private string _date;
  private string _prompt;
  private string _details;

  public string date
  {
    get { return _date; }
  }
  public string prompt
  {
    get { return _prompt; }
  }
  public string details
  {
    get { return _details; }
  }
  public Entry(string prompt, string details)
  {
    DateTime currentDate = DateTime.Now;
    _date = currentDate.ToString("MM-dd-yyyy");
    _prompt = prompt;
    _details = details;
  }

  [JsonConstructor]
  public Entry(string date, string prompt, string details)
  {
    _date = date;
    _prompt = prompt;
    _details = details;
  }
  public void Display()
  {
    Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
    Console.WriteLine(_details);
  }

  public string GetStringData()
  {
    return $"{_date} - {_prompt} - {_details}";
  }
}