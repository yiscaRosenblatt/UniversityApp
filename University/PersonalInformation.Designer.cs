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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(42, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(538, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 78);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 5;
            label1.Text = "Personal Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(623, 119);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Messages";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 274);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 7;
            label3.Text = "star messages";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(574, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(175, 104);
            listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(574, 306);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 104);
            listBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 129);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 176);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // PersonalInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Name = "PersonalInformation";
            Text = "PersonalInformation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
      
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Label label5;
    }
}