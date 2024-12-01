using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std_Job
{
    internal class Student : User
    {
        public Student(string username, string password) : base(username, password, "Student"){}
       
        public string Name { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public List<string> Hobbies { get; set; } = new List<string>();
        public List<string> Certificates { get; set; } = new List<string>();
        public List<int> AppliedJobs { get; private set; } = new List<int>();

        private List<Job> AvailableJobs = new List<Job>
        {
            new Job 
            { 
                JobId = 1, 
                JobTitle = "Software Developer", 
                CompanyName = "EPAM", 
                Description = "Using top-notch engineering, strategy, design, consulting, education, and innovation services, develop software services.", 
                RequiredSkills = new List<string> { "C#", "Java", "SQL" , "React"}, 
                Location = "Remote"
            },
            new Job 
            { 
                JobId = 2, 
                JobTitle = "Aerospace Engineer", 
                CompanyName = "LockheedMartin", 
                Description = "Design and construct air and space vehicles, send them to air/space and control access to monitoring system, communicate with the vehicles", 
                RequiredSkills = new List<string> { "ANSYS", "SolidWorks", "Astrograv", "NASAGMAT", "OpenRocket"}, 
                Location = "On-site"
            },
            new Job 
            { 
                JobId = 3, 
                JobTitle = "Lawyer", 
                CompanyName = "PearsonLawFirm", 
                Description = "Defend the rights of real or legal persons, provide guidance in law and legal affairs.", 
                RequiredSkills = new List<string> { "AnalyticalThinking", "FluentSpeaking", "TakeResponsibility" }, 
                Location = "Hybrid"
            },
            new Job
            {
                JobId = 4,
                JobTitle = "Forest Engineer",
                CompanyName = "Stuntzner",
                Description = "Evaluate all kinds of factors such as ecology, soil, temperature, precipitation, biology of the species, know and apply Forest Establishment Techniques",
                RequiredSkills = new List<string> { "ForestSciences" , "DesignandCreativity", "InterestInNature"},
                Location = "On-site"
            }
        };
        public void CreateProfile()
        {
            Console.WriteLine($"Welcome, {Name}! Let's begin to create your profile pal !");

            Console.Write("Enter your skills (Make it comma-separated please e.g., Java, ANSYS, FluentX etc.): ");
            string inputSkills = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputSkills))
            {
            Skills = inputSkills.Split(',').Select(s => s.Trim()).ToList();
            Console.WriteLine("Skills added to your profile.");
            }
            else
            {
                Console.WriteLine("No skills were entered.");
            }

            var suggestedJobs = AvailableJobs
                .Where(job => job.RequiredSkills.Any(skill => Skills.Contains(skill)))
                .ToList(); // Use of LINQ to suggest jobs based on a student's skills.

            Console.WriteLine("\nBased on your skills, these jobs are matching: ");
            foreach (var job in suggestedJobs)
            {
                Console.WriteLine($"- {job.JobTitle} at {job.CompanyName} (Job ID: {job.JobId}, Location: {job.Location})");
            }
        }
        public void AddSkill(string skill)
        {
            if (!string.IsNullOrWhiteSpace(skill) && !Skills.Contains(skill))
            {
                Skills.Add(skill.Trim());
                Console.WriteLine($"{skill} has been added to your skills list.");
            }
            else
            {
                Console.WriteLine("Skill is invalid or already exists in your list.");
            }
        }
        public void ApplyForJob(int jobId)
        {
            if (AppliedJobs.Contains(jobId))
            {
            Console.WriteLine("You have already applied for this job.");
            return;
            }

            var job = AvailableJobs.FirstOrDefault(j => j.JobId == jobId); // Usage of LINQ to validate job existence in system.

            if (job != null)
            {
                AppliedJobs.Add(jobId);
                Console.WriteLine($"Successfully applied for Job ID: {jobId} - {job.JobTitle} at {job.CompanyName}.");
            }
            else
            {
                Console.WriteLine($"Job ID: {jobId} does not exist.");
            }
        }

        public void UploadResume(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                Console.WriteLine($"Your Resume/CV is uploaded to system successfully from {filePath}.");
            }
            else
            {
                Console.WriteLine("Resume/CV file not found. Please check the file path.");
            }
        }
    }
}

