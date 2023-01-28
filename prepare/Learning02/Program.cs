using System;

class Program
{
    static void Main(string[] args)
    {
        //Job Title 1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //Job Title 2
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //Job Title 3
        Job job3 = new Job();
        job3._jobTitle = "Web Developer";
        job3._company = "Upwork / Freelance";
        job3._startYear = 2019;
        job3._endYear = 2022;

        Job job4 = new Job();
        job4._jobTitle = "Technical Support";
        job4._company = "Upwork / Freelance";
        job4._startYear = 2029;
        job4._endYear = 2032;
        
        //Credentials
        Credentials credentials1 = new Credentials();
        credentials1._School = "STI Muñoz(Senior High)";
        credentials1._Course = "ITMAW Information Technology Mobile App Web Development";
        credentials1._startYear = 2018;
        credentials1._endYear = 2019;

        Credentials credentials2 = new Credentials();
        credentials2._School = "BYU Pathway";
        credentials2._Course = "Certificate Completion / Python";
        credentials2._startYear = 2019;
        credentials2._endYear = 2020;

        //Skills
        Skills skills1 = new Skills();
        skills1._name_skills = "Web Front End - HTML/CSS/React/Javascript/JQuery";

        Skills skills2 = new Skills();
        skills2._name_skills = "Web Front Back End - Python/C#/Java";

        Skills skills3 = new Skills();
        skills3._name_skills = "Database - MySql/SQL Server";

        Skills skills4 = new Skills();
        skills3._name_skills ="Computer Technician - Reformat / Build PC/ Troubleshooting";

        Skills skills5 = new Skills();
        skills5._name_skills  = "MS Word / MS Powerpoint/MS Excel";
 
        //Display Data
        Resume myResume = new Resume();
        //Display Name
        myResume._name = "Mark Augustine Estimada";
        myResume._age = 23;
        myResume._gender = "Male";
        myResume._Address = "Quezon City/ Philippines";

        
        // Display Experiencece
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);

        //Display Credentials
        myResume.__credentials.Add(credentials1);
        myResume.__credentials.Add(credentials2);

        //Skills
        myResume._skills.Add(skills1);
        myResume._skills.Add(skills2);
        myResume._skills.Add(skills3);
        myResume._skills.Add(skills4);
        myResume._skills.Add(skills5);
        myResume.Display();
    }
}