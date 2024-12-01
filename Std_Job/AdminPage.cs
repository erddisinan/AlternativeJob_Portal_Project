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
    public partial class AdminPage : Form
    {
        private User currentUser;  // Store the current logged-in user
        private List<Job> jobList = new List<Job>();

        // Constructor accepting a User object
        public AdminPage(User user)
        {
            InitializeComponent();
            currentUser = user;  // Assign the logged-in user
            lblWelcome.Text = $"Welcome, {currentUser.Username}!";
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // Update label with the logged-in user's username
            //lblWelcome.Text = $"Welcome {currentUser.Username}";
            RefreshJobList();
        }



        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            // Collect job details from input fields (assume GUI has these fields: txtJobTitle, txtCompanyName, etc.)
            string jobTitle = txtJobTitle.Text.Trim();
            string companyName = txtCompanyName.Text.Trim();
            string description = txtJobDescription.Text.Trim();
            string location = txtLocation.Text.Trim();
            var requiredSkills = txtRequiredSkills.Text.Split(',').Select(skill => skill.Trim()).ToList();

            if (string.IsNullOrEmpty(jobTitle) || string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Job Title and Company Name are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create and add job
            var newJob = new Job
            {
                JobId = jobList.Count + 1,
                JobTitle = jobTitle,
                CompanyName = companyName,
                Description = description,
                RequiredSkills = requiredSkills,
                Location = location
            };

            jobList.Add(newJob);
            MessageBox.Show("Job created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshJobList(); // Update job list on the GUI
        }



        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            // Delete selected job (assume GUI has a DataGridView named dgvJobs)
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jobId = (int)dgvJobs.SelectedRows[0].Cells["JobId"].Value;
            jobList = jobList.Where(job => job.JobId != jobId).ToList();
            MessageBox.Show($"Job ID {jobId} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshJobList();
        }

        private void btnCheckApplications_Click(object sender, EventArgs e)
        {
            // Assume we have a ListView named lvApplications to show student applications
            lvApplications.Items.Clear();
            // Simulated data for demo purposes
            var applications = new[]
            {
                new { StudentName = "Adam Curve", JobTitle = "Software Developer", Status = "Pending" },
                new { StudentName = "Theodor Garcia", JobTitle = "Aerospace Engineer", Status = "Pending" },
                new { StudentName = "Jane Wilson" , JobTitle = "Lawyer", Status = "Accepted"}
            };

            foreach (var app in applications)
            {
                var listItem = new ListViewItem(new[] { app.StudentName, app.JobTitle, app.Status });
                lvApplications.Items.Add(listItem);
            }
        }

        private void RefreshJobList()
        {
            // Update the job list in the GUI
            dgvJobs.DataSource = null; // "dgv" = DataGridView.
            dgvJobs.DataSource = jobList;
        }
    }
}