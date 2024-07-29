namespace University.Forms
{
    partial class EditLecturer
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
            label2 = new Label();
            label3 = new Label();
            textBox_firstName = new TextBox();
            textBox_lestName = new TextBox();
            textBox_ID = new TextBox();
            button_Add = new Button();
            button_Delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 87);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "first name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 150);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "lest name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 218);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(156, 87);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(125, 27);
            textBox_firstName.TabIndex = 3;
            // 
            // textBox_lestName
            // 
            textBox_lestName.Location = new Point(156, 150);
            textBox_lestName.Name = "textBox_lestName";
            textBox_lestName.Size = new Size(125, 27);
            textBox_lestName.TabIndex = 4;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(156, 215);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(125, 27);
            textBox_ID.TabIndex = 5;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(47, 278);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 6;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(47, 326);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(94, 29);
            button_Delete.TabIndex = 7;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // EditLecturer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 420);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(textBox_ID);
            Controls.Add(textBox_lestName);
            Controls.Add(textBox_firstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditLecturer";
            Text = "EditLecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_firstName;
        private TextBox textBox_lestName;
        private TextBox textBox_ID;
        private Button button_Add;
        private Button button_Delete;
    }
}