namespace Std_Job
{
    partial class AdminPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCreateJob = new Button();
            btnDeleteJob = new Button();
            btnCheckApplications = new Button();
            lblWelcome = new Label();
            dgvJobs = new DataGridView();
            txtJobTitle = new TextBox();
            txtCompanyName = new TextBox();
            txtJobDescription = new TextBox();
            txtLocation = new TextBox();
            txtRequiredSkills = new TextBox();
            lblJobTitle = new Label();
            lblCompanyName = new Label();
            lblJobDescription = new Label();
            lblLocation = new Label();
            lblRequiredSkills = new Label();
            lvApplications = new ListView();

            SuspendLayout();

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(182, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Admin!";

            // dgvJobs
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(20, 70);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.Size = new Size(600, 200);
            dgvJobs.TabIndex = 1;

            // txtJobTitle
            txtJobTitle.Location = new Point(150, 300);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(200, 23);
            txtJobTitle.TabIndex = 2;

            // txtCompanyName
            txtCompanyName.Location = new Point(150, 330);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(200, 23);
            txtCompanyName.TabIndex = 3;

            // txtJobDescription
            txtJobDescription.Location = new Point(150, 360);
            txtJobDescription.Name = "txtJobDescription";
            txtJobDescription.Size = new Size(200, 23);
            txtJobDescription.TabIndex = 4;

            // txtLocation
            txtLocation.Location = new Point(150, 390);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(200, 23);
            txtLocation.TabIndex = 5;

            // txtRequiredSkills
            txtRequiredSkills.Location = new Point(150, 420);
            txtRequiredSkills.Name = "txtRequiredSkills";
            txtRequiredSkills.Size = new Size(200, 23);
            txtRequiredSkills.TabIndex = 6;

            // Labels
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(20, 300);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(55, 15);
            lblJobTitle.TabIndex = 7;
            lblJobTitle.Text = "Job Title:";

            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(20, 330);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(95, 15);
            lblCompanyName.TabIndex = 8;
            lblCompanyName.Text = "Company Name:";

            lblJobDescription.AutoSize = true;
            lblJobDescription.Location = new Point(20, 360);
            lblJobDescription.Name = "lblJobDescription";
            lblJobDescription.Size = new Size(92, 15);
            lblJobDescription.TabIndex = 9;
            lblJobDescription.Text = "Job Description:";

            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(20, 390);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(58, 15);
            lblLocation.TabIndex = 10;
            lblLocation.Text = "Location:";

            lblRequiredSkills.AutoSize = true;
            lblRequiredSkills.Location = new Point(20, 420);
            lblRequiredSkills.Name = "lblRequiredSkills";
            lblRequiredSkills.Size = new Size(90, 15);
            lblRequiredSkills.TabIndex = 11;
            lblRequiredSkills.Text = "Required Skills:";

            // btnCreateJob
            btnCreateJob.Location = new Point(400, 300);
            btnCreateJob.Name = "btnCreateJob";
            btnCreateJob.Size = new Size(200, 30);
            btnCreateJob.TabIndex = 12;
            btnCreateJob.Text = "Create Job";
            btnCreateJob.UseVisualStyleBackColor = true;
            btnCreateJob.Click += btnCreateJob_Click;

            // btnDeleteJob
            btnDeleteJob.Location = new Point(400, 340);
            btnDeleteJob.Name = "btnDeleteJob";
            btnDeleteJob.Size = new Size(200, 30);
            btnDeleteJob.TabIndex = 13;
            btnDeleteJob.Text = "Delete Job";
            btnDeleteJob.UseVisualStyleBackColor = true;
            btnDeleteJob.Click += btnDeleteJob_Click;

            // btnCheckApplications
            btnCheckApplications.Location = new Point(400, 380);
            btnCheckApplications.Name = "btnCheckApplications";
            btnCheckApplications.Size = new Size(200, 30);
            btnCheckApplications.TabIndex = 14;
            btnCheckApplications.Text = "Check Applications";
            btnCheckApplications.UseVisualStyleBackColor = true;
            btnCheckApplications.Click += btnCheckApplications_Click;

            // lvApplications
            lvApplications.Location = new Point(650, 70);
            lvApplications.Name = "lvApplications";
            lvApplications.Size = new Size(400, 200);
            lvApplications.TabIndex = 15;

            // AdminPage
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 500);
            Controls.Add(lblWelcome);
            Controls.Add(dgvJobs);
            Controls.Add(txtJobTitle);
            Controls.Add(txtCompanyName);
            Controls.Add(txtJobDescription);
            Controls.Add(txtLocation);
            Controls.Add(txtRequiredSkills);
            Controls.Add(lblJobTitle);
            Controls.Add(lblCompanyName);
            Controls.Add(lblJobDescription);
            Controls.Add(lblLocation);
            Controls.Add(lblRequiredSkills);
            Controls.Add(btnCreateJob);
            Controls.Add(btnDeleteJob);
            Controls.Add(btnCheckApplications);
            Controls.Add(lvApplications);
            Name = "AdminPage";
            Text = "Admin Page";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCreateJob;
        private Button btnDeleteJob;
        private Button btnCheckApplications;
        private Label lblWelcome;
        private DataGridView dgvJobs;
        private TextBox txtJobTitle;
        private TextBox txtCompanyName;
        private TextBox txtJobDescription;
        private TextBox txtLocation;
        private TextBox txtRequiredSkills;
        private Label lblJobTitle;
        private Label lblCompanyName;
        private Label lblJobDescription;
        private Label lblLocation;
        private Label lblRequiredSkills;
        private ListView lvApplications;
    }
}
