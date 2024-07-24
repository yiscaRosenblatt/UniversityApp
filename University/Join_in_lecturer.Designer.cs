namespace University
{
    partial class Join_in_lecturer
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
            titleJoinIn = new Label();
            inputUserName = new TextBox();
            inputPassword = new TextBox();
            lineUserName = new Label();
            password = new Label();
            buttonJoinIn = new Button();
            buttonConnection = new Button();
            titleLecturer = new Label();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // titleJoinIn
            // 
            titleJoinIn.AutoSize = true;
            titleJoinIn.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleJoinIn.Location = new Point(384, 85);
            titleJoinIn.Name = "titleJoinIn";
            titleJoinIn.Size = new Size(102, 27);
            titleJoinIn.TabIndex = 0;
            titleJoinIn.Text = "Join in ";
            // 
            // inputUserName
            // 
            inputUserName.Location = new Point(342, 191);
            inputUserName.Name = "inputUserName";
            inputUserName.Size = new Size(152, 27);
            inputUserName.TabIndex = 1;
            inputUserName.TextChanged += inputUserName_TextChanged;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(342, 266);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(152, 27);
            inputPassword.TabIndex = 3;
            inputPassword.TextChanged += inputPassword_TextChanged;
            // 
            // lineUserName
            // 
            lineUserName.AutoSize = true;
            lineUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lineUserName.Location = new Point(376, 168);
            lineUserName.Name = "lineUserName";
            lineUserName.Size = new Size(84, 20);
            lineUserName.TabIndex = 5;
            lineUserName.Text = "User name";
            lineUserName.Click += userName_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            password.Location = new Point(386, 243);
            password.Name = "password";
            password.Size = new Size(76, 20);
            password.TabIndex = 6;
            password.Text = "Password";
            // 
            // buttonJoinIn
            // 
            buttonJoinIn.BackColor = SystemColors.ActiveCaption;
            buttonJoinIn.Location = new Point(274, 328);
            buttonJoinIn.Name = "buttonJoinIn";
            buttonJoinIn.Size = new Size(133, 44);
            buttonJoinIn.TabIndex = 7;
            buttonJoinIn.Text = "Join in";
            buttonJoinIn.UseVisualStyleBackColor = false;
            buttonJoinIn.Click += buttonJoinIn_Click;
            // 
            // buttonConnection
            // 
            buttonConnection.BackColor = SystemColors.ActiveCaption;
            buttonConnection.Location = new Point(432, 328);
            buttonConnection.Name = "buttonConnection";
            buttonConnection.Size = new Size(133, 44);
            buttonConnection.TabIndex = 8;
            buttonConnection.Text = "sign up\r\n";
            buttonConnection.UseVisualStyleBackColor = false;
            buttonConnection.Click += buttonConnection_Click;
            // 
            // titleLecturer
            // 
            titleLecturer.AutoSize = true;
            titleLecturer.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLecturer.Location = new Point(342, 38);
            titleLecturer.Name = "titleLecturer";
            titleLecturer.Size = new Size(167, 37);
            titleLecturer.TabIndex = 9;
            titleLecturer.Text = "lecturer\r\n";
            titleLecturer.Click += titleLecturer_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.InactiveCaption;
            buttonBack.Location = new Point(14, 403);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(106, 35);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // Join_in_lecturer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(900, 450);
            Controls.Add(buttonBack);
            Controls.Add(titleLecturer);
            Controls.Add(buttonConnection);
            Controls.Add(buttonJoinIn);
            Controls.Add(password);
            Controls.Add(lineUserName);
            Controls.Add(inputPassword);
            Controls.Add(inputUserName);
            Controls.Add(titleJoinIn);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Join_in_lecturer";
            Text = "Join_in_lecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleJoinIn;
        private TextBox inputUserName;
        private TextBox inputPassword;
        private Label lineUserName;
        private Label password;
        private Button buttonJoinIn;
        private Button buttonConnection;
        private Label titleLecturer;
        private Button buttonBack;
    }
}