using System;

public class Credentials
{
    public string _School;
    public string _Course;
    public int _startYear;

    public int _endYear;


    public void Display()
    {
        Console.WriteLine($"{_School} <{_Course}> {_startYear}-{_endYear}");
        
    }
}
