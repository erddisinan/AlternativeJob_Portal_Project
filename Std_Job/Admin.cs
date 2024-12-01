using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std_Job
{
    internal class Admin : User
    {
        public List<Job> Jobs { get; set; } = new List<Job>();
        public Dictionary<int, string> Applications { get; set; } = new Dictionary<int, string>(); //Each ID is unique and assosiated/connected to one value.
        public Admin(string username, string password) : base(username, password, "Admin"){}
        public string Name { get; set; }

        
        public void CreateJob(Job job)
        {
            Jobs.Add(job);
            Console.WriteLine($"Job '{job.JobTitle}' at {job.CompanyName} has been created with ID: {job.JobId}.");
        }
        
        
        public void UpdateJob(Job UpdatedJob)
        {
            var ExistingJob = Jobs.FirstOrDefault(j => j.JobId == UpdatedJob.JobId);
            if (ExistingJob != null)
            {
                ExistingJob.JobTitle = UpdatedJob.JobTitle;
                ExistingJob.CompanyName = UpdatedJob.CompanyName;
                ExistingJob.Description = UpdatedJob.Description;
                ExistingJob.RequiredSkills = UpdatedJob.RequiredSkills;
                ExistingJob.Location = UpdatedJob.Location;
                Console.WriteLine($"Job ID {UpdatedJob.JobId} has been updated.");
            }
            else
            {
                Console.WriteLine($"Job ID {UpdatedJob.JobId} not found.");
            }
        }

        
        public void DeleteJob(int jobId)
        {
            var job = Jobs.FirstOrDefault(j => j.JobId == jobId);
            if (job != null)
            {
                Jobs.Remove(job);
                Console.WriteLine($"Job ID {jobId} has been deleted clearly.");
            }
            else
            {
                Console.WriteLine($"Job ID {jobId} cannot found.");
            }
        }
        
        public void ReviewApplication(int ApplicationId, string status)
        {
            if (Applications.ContainsKey(ApplicationId))
            {
                Applications[ApplicationId] = status;
                Console.WriteLine($"Application ID {ApplicationId} has been updated to '{status}' precisely.");
            }
            else
            {
                Console.WriteLine($"Application ID {ApplicationId} cannot found.");
            }
        }

        public void FindJobsBySkill(string skill)
        {
            var jobsWithSkill = Jobs.Where(j => j.RequiredSkills.Contains(skill)).ToList(); // Usage of LINQ Query for matching Jobs with related Skills.

            Console.WriteLine($"\nJobs requiring '{skill}':");
            foreach (var job in jobsWithSkill)
            {
                Console.WriteLine($"- {job.JobTitle} at {job.CompanyName} (Job ID: {job.JobId}, Location: {job.Location})");
            }

            if (!jobsWithSkill.Any())
            {
                Console.WriteLine("No jobs found for the specified skill.");
            }
        }
    }
}

