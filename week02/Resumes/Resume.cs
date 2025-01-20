public class Resume
{
  public string _name { get; set; }
  public List<Job> _jobs { get; set; }

  // Constructor with only name argument, initialize jobs as empty list of Job type
  public Resume(string name) : this(name, new List<Job>()) { }

  // Cosntructor with name and jobs list arguments
  public Resume(string name, List<Job> jobs)
  {
    _name = name;
    _jobs = jobs;
  }

  // AddJob Method
  public void AddJob(Job job)
  {
    _jobs.Add(job);
  }

  // Resumen Display method
  public void Display()
  {
    Console.WriteLine($"Name: {_name}");
    // Print list of jobs if list is not empty othewise print statement "No jobs to show"
    if (_jobs.Count > 0)
    {
      Console.WriteLine("Jobs:");
      foreach (Job job in _jobs)
      {
        job.Display();
      }
    }
    else
    {
      Console.WriteLine("No jobs to show");
    }
  }
}
