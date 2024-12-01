namespace Std_Job
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameEntryArea = new TextBox();
            passwordEntryArea = new TextBox();
            label1 = new Label();
            registerButton = new Button();
            loginButtonClick = new Button();
            SuspendLayout();
            // 
            // nameEntryArea
            // 
            nameEntryArea.Location = new Point(256, 151);
            nameEntryArea.Name = "nameEntryArea";
            nameEntryArea.Size = new Size(280, 23);
            nameEntryArea.TabIndex = 1;
            
            // 
            // passwordEntryArea
            // 
            passwordEntryArea.Location = new Point(256, 238);
            passwordEntryArea.Name = "passwordEntryArea";
            passwordEntryArea.Size = new Size(280, 23);
            passwordEntryArea.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(272, 56);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 3;
            label1.Text = "Student Job Matching";
            
            // 
            // registerButton
            // 
            registerButton.Location = new Point(297, 393);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(199, 42);
            registerButton.TabIndex = 4;
            registerButton.Text = "Do not have account? Register!";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButtonClick
            // 
            loginButtonClick.Location = new Point(297, 335);
            loginButtonClick.Name = "loginButtonClick";
            loginButtonClick.Size = new Size(199, 42);
            loginButtonClick.TabIndex = 0;
            loginButtonClick.Text = "Login";
            loginButtonClick.UseVisualStyleBackColor = true;
            loginButtonClick.Click += loginButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 494);
            Controls.Add(registerButton);
            Controls.Add(label1);
            Controls.Add(passwordEntryArea);
            Controls.Add(nameEntryArea);
            Controls.Add(loginButtonClick);
            Name = "LoginPage";
            Text = "JobApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameEntryArea;
        private TextBox passwordEntryArea;
        private Label label1;
        private Button registerButton;
        private Button loginButtonClick;
    }
}
