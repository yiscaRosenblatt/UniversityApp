namespace University
{
    partial class frontFage
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
            LecturerButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(488, 189);
            button1.Name = "button1";
            button1.Size = new Size(261, 100);
            button1.TabIndex = 0;
            button1.Text = "Students";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LecturerButton
            // 
            LecturerButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LecturerButton.ForeColor = SystemColors.ActiveCaptionText;
            LecturerButton.Location = new Point(85, 189);
            LecturerButton.Name = "LecturerButton";
            LecturerButton.Size = new Size(261, 100);
            LecturerButton.TabIndex = 1;
            LecturerButton.Text = "lecturers";
            LecturerButton.UseVisualStyleBackColor = true;
            LecturerButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(180, 53);
            label1.Name = "label1";
            label1.Size = new Size(471, 31);
            label1.TabIndex = 2;
            label1.Text = "Welcome to the university's website";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(352, 103);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Who are you???";
            label2.Click += label2_Click;
            // 
            // frontFage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LecturerButton);
            Controls.Add(button1);
            Name = "frontFage";
            Text = "frontFage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button LecturerButton;
        private Label label1;
        private Label label2;
    }
}