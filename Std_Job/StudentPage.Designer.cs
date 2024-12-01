namespace Std_Job
{
    partial class StudentPage
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
            lblWelcome = new Label();
            dgvJobs = new DataGridView();
            lvApplications = new ListView();
            btnJobExplorer = new Button();
            btnCheckAppStatus = new Button();
            btnResumeGenerator = new Button();

            SuspendLayout();

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(182, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Student!";

            // dgvJobs
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(20, 70);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.Size = new Size(600, 200);
            dgvJobs.TabIndex = 1;

            // lvApplications
            lvApplications.Location = new Point(650, 70);
            lvApplications.Name = "lvApplications";
            lvApplications.Size = new Size(400, 200);
            lvApplications.TabIndex = 2;

            // btnJobExplorer
            btnJobExplorer.Location = new Point(20, 300);
            btnJobExplorer.Name = "btnJobExplorer";
            btnJobExplorer.Size = new Size(200, 30);
            btnJobExplorer.TabIndex = 3;
            btnJobExplorer.Text = "Explore Jobs";
            btnJobExplorer.UseVisualStyleBackColor = true;
            btnJobExplorer.Click += btnJobExplorer_Click;

            // btnCheckAppStatus
            btnCheckAppStatus.Location = new Point(250, 300);
            btnCheckAppStatus.Name = "btnCheckAppStatus";
            btnCheckAppStatus.Size = new Size(200, 30);
            btnCheckAppStatus.TabIndex = 4;
            btnCheckAppStatus.Text = "Check Application Status";
            btnCheckAppStatus.UseVisualStyleBackColor = true;
            btnCheckAppStatus.Click += btnCheckAppStatus_Click;

            // btnResumeGenerator
            btnResumeGenerator.Location = new Point(480, 300);
            btnResumeGenerator.Name = "btnResumeGenerator";
            btnResumeGenerator.Size = new Size(200, 30);
            btnResumeGenerator.TabIndex = 5;
            btnResumeGenerator.Text = "Generate Resume";
            btnResumeGenerator.UseVisualStyleBackColor = true;
            btnResumeGenerator.Click += btnResumeGenerator_Click;

            // StudentPage
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 400);
            Controls.Add(lblWelcome);
            Controls.Add(dgvJobs);
            Controls.Add(lvApplications);
            Controls.Add(btnJobExplorer);
            Controls.Add(btnCheckAppStatus);
            Controls.Add(btnResumeGenerator);
            Name = "StudentPage";
            Text = "Student Page";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblWelcome;
        private DataGridView dgvJobs;
        private ListView lvApplications;
        private Button btnJobExplorer;
        private Button btnCheckAppStatus;
        private Button btnResumeGenerator;
    }
}
