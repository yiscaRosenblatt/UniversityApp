using System;
using System.Drawing;
using System.Windows.Forms;

namespace University
{
    public partial class FrontPage : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FrontPage()
        {
            InitializeComponent();
        }

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
            titleWelcome = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(488, 236);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(261, 125);
            button1.TabIndex = 0;
            button1.Text = "Students";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LecturerButton
            // 
            LecturerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LecturerButton.ForeColor = SystemColors.ActiveCaptionText;
            LecturerButton.Location = new Point(85, 236);
            LecturerButton.Margin = new Padding(3, 4, 3, 4);
            LecturerButton.Name = "LecturerButton";
            LecturerButton.Size = new Size(261, 125);
            LecturerButton.TabIndex = 1;
            LecturerButton.Text = "Lecturers";
            LecturerButton.UseVisualStyleBackColor = true;
            LecturerButton.Click += LecturerButton_Click;
            // 
            // titleWelcome
            // 
            titleWelcome.AutoSize = true;
            titleWelcome.BackColor = Color.Azure;
            titleWelcome.BorderStyle = BorderStyle.FixedSingle;
            titleWelcome.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleWelcome.ForeColor = SystemColors.ControlDark;
            titleWelcome.Location = new Point(59, 84);
            titleWelcome.Name = "titleWelcome";
            titleWelcome.Size = new Size(704, 45);
            titleWelcome.TabIndex = 2;
            titleWelcome.Text = "Welcome to the university's website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(326, 145);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 3;
            label2.Text = "Who are you???";
            // 
            // FrontPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 562);
            Controls.Add(label2);
            Controls.Add(titleWelcome);
            Controls.Add(LecturerButton);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrontPage";
            Text = "Front Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LecturerButton;
        private System.Windows.Forms.Label titleWelcome;
        private System.Windows.Forms.Label label2;
    }
}
