using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Std_Job
{
    public partial class StudentPage : Form
    {
        private User currentUser;  // Store the current logged-in user
        private List<Job> availableJobs = new List<Job>(); // Used to simulate a job database.
        // Constructor accepting a User object (Student)
        public StudentPage(User user)
        {
            InitializeComponent();
            currentUser = user;  // Assign the logged-in user
            lblWelcome.Text = $"Welcome, {currentUser.Username}!";
            LoadAvailableJobs();
        }

        private void btnCheckAppStatus_Click(object sender, EventArgs e)
        {
            lvApplications.Items.Clear();
            var appliedJobs = new[]
            {
                new {JobTitle = "Software Developer", CompanyName = "EPAM", Status = "Pending"},
                new {JobTitle = "Aerospace Engineer", CompanyName = "LockheedMartin", Status = "Pending"},
                new {JobTitle = "Aerospace Engineer", CompanyName = "TAI", Status = "Pending"},
                new {JobTitle = "Software Developer", CompanyName = "Microsoft", Status = "Pending"},
                new {JobTitle = "Lawyer", CompanyName = "Pearson", Status = "Pending"},
                new {JobTitle = "Forest Engineer", CompanyName = "Stuntzer", Status = "Accepted"},

            };
            foreach (var app in appliedJobs)
            {
                var listItem = new ListViewItem(new[] { app.JobTitle, app.CompanyName, app.Status });
                lvApplications.Items.Add(listItem);
            }
        }

        private void btnJobExplorer_Click(object sender, EventArgs e)
        {
            // It will show all jobs. 
            dgvJobs.DataSource = null; // "dgv" : DataGridView.
            dgvJobs.DataSource = availableJobs;
        }


        private void btnResumeGenerator_Click(object sender, EventArgs e)
        {
            // Simulate generating a resume
            MessageBox.Show("Resume generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadAvailableJobs()
        {
            // Simulate available jobs for demo purposes
            availableJobs.Add(
            new Job
            {
                JobId = 1,
                JobTitle = "Software Developer",
                CompanyName = "EPAM",
                Description = "Using top-notch engineering, strategy, design, consulting, education, and innovation services, develop software services.",
                RequiredSkills = new List<string> { "C#", "Java", "SQL", "React", "CSS", "Python" },
                Location = "Remote"
            });

            availableJobs.Add(
            new Job
            {
                JobId = 2,
                JobTitle = "Lawyer",
                CompanyName = "Pearson",
                Description = "Defend the rights of real or legal persons, provide guidance in law and legal affairs.",
                RequiredSkills = new List<string> { "AnalyticalThinking", "FluentSpeaking", "TakeResponsibility" },
                Location = "Hybrid"
            });

            availableJobs.Add(
            new Job
            {
                JobId = 3,
                JobTitle = "Aerospace Engineer",
                CompanyName = "LockheedMartin",
                Description = "Design and construct air and space vehicles, send them to air/space and control access to monitoring system, communicate with the vehicles",
                RequiredSkills = new List<string> { "ANSYS", "SolidWorks", "Astrograv", "NASAGMAT", "OpenRocket" },
                Location = "On-site"
            });

            availableJobs.Add(
            new Job
            {
                JobId = 4,
                JobTitle = "Forest Engineer",
                CompanyName = "Stuntzner",
                Description = "Evaluate all kinds of factors such as ecology, soil, temperature, precipitation, biology of the species, know and apply Forest Establishment Techniques",
                RequiredSkills = new List<string> { "ForestSciences", "DesignandCreativity", "InterestInNature" },
                Location = "On-site"
            });

            dgvJobs.DataSource = availableJobs;
        }
    }
}
