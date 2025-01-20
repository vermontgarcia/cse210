public class Job
{
  public string _company { get; set; }
  public string _jobTitle { get; set; }
  public int _startYear { get; set; }
  public int _endYear { get; set; }

  public Job() { }
  // Constructor when the job is the current job (no End Date) endYear set to 0
  public Job(string company, string jobTitle, int startYear) : this(company, jobTitle, startYear, 0) { }

  // Constructor when job is a past job
  public Job(string company, string jobTitle, int startYear, int endYear)
  {
    _company = company;
    _jobTitle = jobTitle;
    _startYear = startYear;
    _endYear = endYear;
  }

  public void Display()
  {
    // If no endYear show as Currently Employed job, otherwise shows period with start year and end year
    if (_endYear == 0)
    {
      Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - Currently Employed");
    }
    else
    {
      Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
  }
}
