namespace Std_Job
{
    partial class RegisterPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idEntryArea = new TextBox();
            passwordRegisterArea = new TextBox();
            confirmPasswordArea = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RegistirationButtonClick = new Button();
            SuspendLayout();
            // 
            // idEntryArea
            // 
            idEntryArea.Location = new Point(282, 108);
            idEntryArea.Name = "idEntryArea";
            idEntryArea.Size = new Size(244, 23);
            idEntryArea.TabIndex = 0;
            idEntryArea.TextChanged += idEntryArea_TextChanged;
            // 
            // passwordRegisterArea
            // 
            passwordRegisterArea.Location = new Point(282, 183);
            passwordRegisterArea.Name = "passwordRegisterArea";
            passwordRegisterArea.Size = new Size(244, 23);
            passwordRegisterArea.TabIndex = 1;
            // 
            // confirmPasswordArea
            // 
            confirmPasswordArea.Location = new Point(282, 257);
            confirmPasswordArea.Name = "confirmPasswordArea";
            confirmPasswordArea.Size = new Size(244, 23);
            confirmPasswordArea.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 111);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter your ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 186);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter your password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 260);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirm password";
            label3.Click += label3_Click;
            // 
            // RegistirationButtonClick
            // 
            RegistirationButtonClick.Location = new Point(299, 335);
            RegistirationButtonClick.Name = "RegistirationButtonClick";
            RegistirationButtonClick.Size = new Size(199, 42);
            RegistirationButtonClick.TabIndex = 6;
            RegistirationButtonClick.Text = "Register";
            RegistirationButtonClick.UseVisualStyleBackColor = true;
            RegistirationButtonClick.Click += RegistirationButton_Click;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegistirationButtonClick);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(confirmPasswordArea);
            Controls.Add(passwordRegisterArea);
            Controls.Add(idEntryArea);
            Name = "RegisterPage";
            Text = "RegisterPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idEntryArea;
        private TextBox passwordRegisterArea;
        private TextBox confirmPasswordArea;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RegistirationButtonClick;
    }
}