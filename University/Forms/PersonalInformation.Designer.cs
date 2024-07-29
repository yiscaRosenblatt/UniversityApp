using System.Windows.Forms;

namespace University
{
    partial class PersonalInformation
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button_Course = new Button();
            button_Student = new Button();
            button_lectueer = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.na_na;
            pictureBox1.Location = new Point(23, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 30);
            label1.Name = "label1";
            label1.Size = new Size(377, 37);
            label1.TabIndex = 5;
            label1.Text = "Personal Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(639, 109);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 6;
            label2.Text = "lest Message";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(623, 264);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 7;
            label3.Text = "star messages";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 154);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 202);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 11;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(220, 243);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 12;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 286);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 13;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(220, 321);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 14;
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(51, 333);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Change image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 16;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button_Course
            // 
            button_Course.Location = new Point(442, 149);
            button_Course.Name = "button_Course";
            button_Course.Size = new Size(94, 29);
            button_Course.TabIndex = 18;
            button_Course.Text = "Course";
            button_Course.UseVisualStyleBackColor = true;
            button_Course.Click += button_Course_Click;
            // 
            // button_Student
            // 
            button_Student.Location = new Point(442, 202);
            button_Student.Name = "button_Student";
            button_Student.Size = new Size(94, 29);
            button_Student.TabIndex = 19;
            button_Student.Text = "Student";
            button_Student.UseVisualStyleBackColor = true;
            button_Student.Click += button_Student_Click;
            // 
            // button_lectueer
            // 
            button_lectueer.Location = new Point(442, 264);
            button_lectueer.Name = "button_lectueer";
            button_lectueer.Size = new Size(94, 29);
            button_lectueer.TabIndex = 21;
            button_lectueer.Text = "lectueer";
            button_lectueer.UseVisualStyleBackColor = true;
            button_lectueer.Click += button_lectueer_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(563, 132);
            listView1.Name = "listView1";
            listView1.Size = new Size(246, 121);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(563, 301);
            listView2.Name = "listView2";
            listView2.Size = new Size(246, 121);
            listView2.TabIndex = 23;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // PersonalInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(821, 450);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(button_lectueer);
            Controls.Add(button_Student);
            Controls.Add(button_Course);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PersonalInformation";
            Text = "PersonalInformation";
            Load += PersonalInformation_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
      
       
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button_Course;
        private Button button_Student;
        private Button button_lectueer;
        private ListView listView1;
        private ListView listView2;
    }
}