using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating Job instances (Curremt Employment no endYear)
        Job job1 = new Job("Microsoft", "Sr. Software Engineer", 2020);
        Job job2 = new Job("Amazon", "Software Engineer", 2013, 2020);

        // Instantiating Resume instance with name parameter only and then adding jobs with AddJob method 
        Resume resume = new Resume("Vermont Garcia");
        resume.AddJob(job1);
        resume.AddJob(job2);
        resume.Display();
        Console.WriteLine("");

        // Instantiating Resume instance with name and jobs parameters
        Resume resume2 = new Resume("John Dow", [job1, job2]);
        resume2.Display();
        Console.WriteLine("");

        // Instatiating Resume instance with only name parameter Display method shows "No jobs to show"
        Resume resume3 = new Resume("Iris Gerber");
        resume3.Display();
    }
}