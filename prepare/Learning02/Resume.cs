public class Resume { 
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display() { 
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs: ");

        // Notice the use of the custom data type
        // "Job" in this loop
        
        foreach (Job job in _jobs)  {
            job.DisplayJobDetails();
        }
    } 
    }
