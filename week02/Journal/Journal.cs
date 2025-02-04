using System.IO;
using System.Text.Json;

public class Journal
{
  List<Entry> _entries = new List<Entry>();
  public Journal() { }

  public void AddEntry(Entry entry)
  {
    _entries.Add(entry);
  }

  public void SetEntries(List<Entry> entries)
  {
    _entries = entries;
  }

  public void DisplayAllEntries()
  {
    foreach (Entry entry in _entries)
    {
      Console.WriteLine("");
      entry.Display();
    }
  }

  // Function to write to TXT file and populate entries
  public void SaveToTextFile(string fileName)
  {
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      DateTime theCurrentTime = DateTime.Now;
      string dateText = theCurrentTime.ToShortDateString();
      outputFile.WriteLine($"Journal Exported {dateText}");
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine(entry.GetStringData());
      }
    }

  }

  // Function to write to JSON file and populate entries
  public void SaveToJsonFile(string fileName)
  {
    var options = new JsonSerializerOptions
    {
      WriteIndented = true
    };
    string jsonString = JsonSerializer.Serialize(_entries, options);
    File.WriteAllText(fileName, jsonString);
  }

  // Function to read from JSON file and populate entries
  public void ReadFromJsonFile(string fileName)
  {
    string jsonString = File.ReadAllText(fileName);
    List<Entry> entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
    _entries = entries;
  }

  // Function to read from TXT file and populate entries
  public void LoadFromTextFile(string fileName)
  {
    string[] lines = File.ReadAllLines(fileName);
    string[] newLines = lines.Skip(1).ToArray();
    foreach (string line in newLines)
    {
      string[] parts = line.Split(" - ");
      Entry entry = new Entry(parts[0], parts[1], parts[2]);
      _entries.Add(entry);
    }
  }
}