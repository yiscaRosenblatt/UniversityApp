namespace University.Forms
{
    partial class EditStusent1
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
            label4 = new Label();
            textBox_firstName = new TextBox();
            textBox_lestName = new TextBox();
            textBox_ID = new TextBox();
            button_delete = new Button();
            button_Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 46);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Edit student ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 92);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "first name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 138);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "lest name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 185);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 3;
            label4.Text = "ID:";
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(140, 89);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(125, 27);
            textBox_firstName.TabIndex = 4;
            // 
            // textBox_lestName
            // 
            textBox_lestName.Location = new Point(140, 138);
            textBox_lestName.Name = "textBox_lestName";
            textBox_lestName.Size = new Size(125, 27);
            textBox_lestName.TabIndex = 5;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(140, 185);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(125, 27);
            textBox_ID.TabIndex = 6;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(39, 251);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 7;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(39, 297);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 8;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // EditStusent1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 416);
            Controls.Add(button_Add);
            Controls.Add(button_delete);
            Controls.Add(textBox_ID);
            Controls.Add(textBox_lestName);
            Controls.Add(textBox_firstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditStusent1";
            Text = "EditStusent1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_firstName;
        private TextBox textBox_lestName;
        private TextBox textBox_ID;
        private Button button_delete;
        private Button button_Add;
    }
}