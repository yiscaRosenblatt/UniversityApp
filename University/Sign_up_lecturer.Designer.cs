namespace University
{
    partial class Sign_up_lecturer
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
            inputLastName = new TextBox();
            inputFirstName = new TextBox();
            inputUserName = new TextBox();
            inputPassword = new TextBox();
            inputPasswordAuthentication = new TextBox();
            inputID = new TextBox();
            inputEmail = new TextBox();
            titleSignUp = new Label();
            firstName = new Label();
            lastName = new Label();
            id = new Label();
            email = new Label();
            userName = new Label();
            password = new Label();
            passwordAuthentication = new Label();
            titleLecturer = new Label();
            buttonBack = new Button();
            buttonSignUp = new Button();
            codeLecturer = new Label();
            inputCodeLecturer = new TextBox();
            SuspendLayout();
            // 
            // inputLastName
            // 
            inputLastName.Location = new Point(202, 202);
            inputLastName.Name = "inputLastName";
            inputLastName.Size = new Size(140, 27);
            inputLastName.TabIndex = 0;
            inputLastName.TextChanged += inputLastName_TextChanged;
            // 
            // inputFirstName
            // 
            inputFirstName.Location = new Point(202, 141);
            inputFirstName.Name = "inputFirstName";
            inputFirstName.Size = new Size(140, 27);
            inputFirstName.TabIndex = 1;
            inputFirstName.TextChanged += inputFirstName_TextChanged;
            // 
            // inputUserName
            // 
            inputUserName.Location = new Point(631, 131);
            inputUserName.Name = "inputUserName";
            inputUserName.Size = new Size(140, 27);
            inputUserName.TabIndex = 2;
            inputUserName.TextChanged += inputUserName_TextChanged;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(631, 199);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(140, 27);
            inputPassword.TabIndex = 3;
            inputPassword.TextChanged += inputPassword_TextChanged;
            // 
            // inputPasswordAuthentication
            // 
            inputPasswordAuthentication.Location = new Point(631, 271);
            inputPasswordAuthentication.Name = "inputPasswordAuthentication";
            inputPasswordAuthentication.Size = new Size(140, 27);
            inputPasswordAuthentication.TabIndex = 4;
            inputPasswordAuthentication.TextChanged += inputPasswordAuthentication_TextChanged;
            // 
            // inputID
            // 
            inputID.Location = new Point(202, 267);
            inputID.Name = "inputID";
            inputID.Size = new Size(140, 27);
            inputID.TabIndex = 5;
            inputID.TextChanged += inputID_TextChanged;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(202, 334);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(140, 27);
            inputEmail.TabIndex = 6;
            inputEmail.TextChanged += inputEmail_TextChanged;
            // 
            // titleSignUp
            // 
            titleSignUp.AutoSize = true;
            titleSignUp.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleSignUp.Location = new Point(358, 60);
            titleSignUp.Name = "titleSignUp";
            titleSignUp.Size = new Size(116, 27);
            titleSignUp.TabIndex = 7;
            titleSignUp.Text = "Sign up ";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.BackColor = SystemColors.ActiveBorder;
            firstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            firstName.Location = new Point(83, 144);
            firstName.Name = "firstName";
            firstName.Size = new Size(83, 20);
            firstName.TabIndex = 8;
            firstName.Text = "First name";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.BackColor = SystemColors.ActiveBorder;
            lastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lastName.Location = new Point(82, 206);
            lastName.Name = "lastName";
            lastName.Size = new Size(81, 20);
            lastName.TabIndex = 9;
            lastName.Text = "Last name";
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = SystemColors.ActiveBorder;
            id.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            id.Location = new Point(110, 277);
            id.Name = "id";
            id.Size = new Size(25, 20);
            id.TabIndex = 10;
            id.Text = "ID";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = SystemColors.ActiveBorder;
            email.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            email.Location = new Point(98, 341);
            email.Name = "email";
            email.Size = new Size(47, 20);
            email.TabIndex = 11;
            email.Text = "Email";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = SystemColors.ActiveBorder;
            userName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userName.Location = new Point(485, 137);
            userName.Name = "userName";
            userName.Size = new Size(84, 20);
            userName.TabIndex = 12;
            userName.Text = "User name";
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = SystemColors.ActiveBorder;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            password.Location = new Point(485, 202);
            password.Name = "password";
            password.Size = new Size(76, 20);
            password.TabIndex = 13;
            password.Text = "Password";
            // 
            // passwordAuthentication
            // 
            passwordAuthentication.AutoSize = true;
            passwordAuthentication.BackColor = SystemColors.ActiveBorder;
            passwordAuthentication.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passwordAuthentication.Location = new Point(425, 277);
            passwordAuthentication.Name = "passwordAuthentication";
            passwordAuthentication.Size = new Size(185, 20);
            passwordAuthentication.TabIndex = 14;
            passwordAuthentication.Text = "Password Authentication";
            // 
            // titleLecturer
            // 
            titleLecturer.AutoSize = true;
            titleLecturer.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLecturer.Location = new Point(329, 23);
            titleLecturer.Name = "titleLecturer";
            titleLecturer.Size = new Size(175, 37);
            titleLecturer.TabIndex = 15;
            titleLecturer.Text = "lecturer";
            titleLecturer.Click += titleLecturer_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ActiveCaption;
            buttonBack.Location = new Point(19, 426);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(88, 29);
            buttonBack.TabIndex = 16;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = SystemColors.ActiveCaption;
            buttonSignUp.Location = new Point(125, 426);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(89, 31);
            buttonSignUp.TabIndex = 17;
            buttonSignUp.Text = "sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // codeLecturer
            // 
            codeLecturer.AutoSize = true;
            codeLecturer.BackColor = SystemColors.ActiveBorder;
            codeLecturer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            codeLecturer.Location = new Point(400, 344);
            codeLecturer.Name = "codeLecturer";
            codeLecturer.Size = new Size(210, 20);
            codeLecturer.TabIndex = 18;
            codeLecturer.Text = "Code for lecturers   (4 digits)";
            // 
            // inputCodeLecturer
            // 
            inputCodeLecturer.Location = new Point(631, 341);
            inputCodeLecturer.Name = "inputCodeLecturer";
            inputCodeLecturer.Size = new Size(140, 27);
            inputCodeLecturer.TabIndex = 19;
            // 
            // Sign_up_lecturer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(900, 469);
            Controls.Add(inputCodeLecturer);
            Controls.Add(codeLecturer);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonBack);
            Controls.Add(titleLecturer);
            Controls.Add(passwordAuthentication);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(email);
            Controls.Add(id);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(titleSignUp);
            Controls.Add(inputEmail);
            Controls.Add(inputID);
            Controls.Add(inputPasswordAuthentication);
            Controls.Add(inputPassword);
            Controls.Add(inputUserName);
            Controls.Add(inputFirstName);
            Controls.Add(inputLastName);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Sign_up_lecturer";
            Text = "Sign_up_lecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputLastName;
        private TextBox inputFirstName;
        private TextBox inputUserName;
        private TextBox inputPassword;
        private TextBox inputPasswordAuthentication;
        private TextBox inputID;
        private TextBox inputEmail;
        private TextBox inputCodeLecturer;
        private Label titleSignUp;
        private Label firstName;
        private Label lastName;
        private Label id;
        private Label email;
        private Label userName;
        private Label password;
        private Label passwordAuthentication;
        private Label titleLecturer;
        private Label codeLecturer;
        private Button buttonBack;
        private Button buttonSignUp;
    }
}