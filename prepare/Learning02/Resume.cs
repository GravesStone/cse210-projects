using System;

public class Resume
{
    //Global Variable
    public string _name;


    public string _gender;
    public string _Address;

    public int _age;
    
    
    

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();
    public List<Credentials> __credentials = new List<Credentials>();
    
    public List<Skills> _skills = new List<Skills>();
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Gender: {_gender}");
        Console.WriteLine($"Age: {_age}");
        Console.WriteLine($"Address: {_Address}");
        Console.WriteLine("--Jobs---");
        //Job
        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
        Console.WriteLine("--Credentials--");
        //Crendentials
        // Notice the use of the custom data type "Credentials" in this loop
        foreach(Credentials credentials in __credentials)
        {
            // This calls the Display method on each Crendential
            credentials.Display();
        }
        //Skills
        Console.WriteLine("--Skills--");
        // Notice the use of the custom data type "Skills" in this loop
        foreach(Skills skills in _skills)
        {
            skills.Display();
        }
        
    }
}