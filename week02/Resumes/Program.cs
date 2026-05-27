using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Access Bank";
        job1._startYear = 2012;
        job1._endYear = 2022;

        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Relationship manager";
        job2._company = "Sterling Bank";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Job job3 = new Job();
        job3._company = "Stanbic";
        job3._jobTitle = "Executive banker";
        job3._startYear = 2025;
        job3._endYear = 2026;

        Resume resume= new Resume();
        resume._name = "Samson Omale";

        resume._Jobs.Add(job1);
        resume._Jobs.Add(job2);
        resume._Jobs.Add(job3);

        resume.Display();
    }
}