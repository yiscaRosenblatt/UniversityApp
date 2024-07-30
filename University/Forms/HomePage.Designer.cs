namespace University
{
    partial class HomePage
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            titleHomePage = new Label();
            logOutButtun = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(94, 198);
            button1.Name = "button1";
            button1.Size = new Size(94, 52);
            button1.TabIndex = 0;
            button1.Text = "Personal Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(211, 198);
            button2.Name = "button2";
            button2.Size = new Size(94, 52);
            button2.TabIndex = 1;
            button2.Text = "Messages";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LemonChiffon;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(331, 198);
            button3.Name = "button3";
            button3.Size = new Size(94, 52);
            button3.TabIndex = 2;
            button3.Text = "people";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LemonChiffon;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(461, 198);
            button4.Name = "button4";
            button4.Size = new Size(94, 52);
            button4.TabIndex = 3;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // titleHomePage
            // 
            titleHomePage.AutoSize = true;
            titleHomePage.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleHomePage.Location = new Point(247, 33);
            titleHomePage.Name = "titleHomePage";
            titleHomePage.Size = new Size(178, 37);
            titleHomePage.TabIndex = 5;
            titleHomePage.Text = "homepage";
            // 
            // logOutButtun
            // 
            logOutButtun.BackColor = Color.Transparent;
            logOutButtun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutButtun.ForeColor = Color.Red;
            logOutButtun.Location = new Point(24, 378);
            logOutButtun.Name = "logOutButtun";
            logOutButtun.Size = new Size(115, 35);
            logOutButtun.TabIndex = 6;
            logOutButtun.Text = "log out";
            logOutButtun.UseVisualStyleBackColor = false;
            logOutButtun.Click += logOutButtun_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(676, 434);
            Controls.Add(logOutButtun);
            Controls.Add(titleHomePage);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label titleHomePage;
        private Button logOutButtun;
    }
}