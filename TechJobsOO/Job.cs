using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        //keeps track of unique id's for new jobs we crate
        //static b/c iterating for every new job class that iterates
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        //type = Employer class, EmployerName = property from Job class
        //EmployerName is and INSTANCE of the Employer class 
        //EmployerName is an OBJECt from Employer class 
        //therefore job.EmployerName.Value = employer name 
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this() //FG <===== ?????
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;


        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            //if a field is empty write “Data not available” 

            if(Name == "")
            {
                Name =  "Data not available";
            }

            if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }

            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }

            return "\n" + 
                $"ID: {Id}\n" +
                $"Name: {Name}\n" + 
                $"Employer: {EmployerName}\n" + 
                $"Location: {EmployerLocation}\n" + 
                $"Position Type: {JobType}\n" + 
                $"Core Competency: {JobCoreCompetency}\n";

          


        }

    }
}
