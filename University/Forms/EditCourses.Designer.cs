namespace University.Forms
{
    partial class EditCourses
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
            label1 = new Label();
            textBox_nameCourse = new TextBox();
            label2 = new Label();
            button_AddNewCourses = new Button();
            button_EditCourses = new Button();
            button_delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 40);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Edit courses";
            // 
            // textBox_nameCourse
            // 
            textBox_nameCourse.Location = new Point(141, 95);
            textBox_nameCourse.Name = "textBox_nameCourse";
            textBox_nameCourse.Size = new Size(146, 27);
            textBox_nameCourse.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "name courses";
            // 
            // button_AddNewCourses
            // 
            button_AddNewCourses.Location = new Point(100, 216);
            button_AddNewCourses.Name = "button_AddNewCourses";
            button_AddNewCourses.Size = new Size(131, 29);
            button_AddNewCourses.TabIndex = 5;
            button_AddNewCourses.Text = "Add new courses";
            button_AddNewCourses.UseVisualStyleBackColor = true;
            button_AddNewCourses.Click += button_AddNewCourses_Click;
            // 
            // button_EditCourses
            // 
            button_EditCourses.Location = new Point(100, 181);
            button_EditCourses.Name = "button_EditCourses";
            button_EditCourses.Size = new Size(131, 29);
            button_EditCourses.TabIndex = 6;
            button_EditCourses.Text = "Edit courses";
            button_EditCourses.UseVisualStyleBackColor = true;
            button_EditCourses.Click += button_EditCourses_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(100, 251);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(131, 29);
            button_delete.TabIndex = 7;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // EditCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 321);
            Controls.Add(button_delete);
            Controls.Add(button_EditCourses);
            Controls.Add(button_AddNewCourses);
            Controls.Add(label2);
            Controls.Add(textBox_nameCourse);
            Controls.Add(label1);
            Name = "EditCourses";
            Text = "EditCourses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_nameCourse;
        private Label label2;
        private Button button_AddNewCourses;
        private Button button_EditCourses;
        private Button button_delete;
    }
}