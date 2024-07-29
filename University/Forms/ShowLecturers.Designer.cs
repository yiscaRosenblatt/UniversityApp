namespace University.Forms
{
    partial class ShowLecturers
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
            listView1 = new ListView();
            button_Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "lecturer";
            // 
            // listView1
            // 
            listView1.Location = new Point(66, 86);
            listView1.Name = "listView1";
            listView1.Size = new Size(440, 277);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += clicked_lecturer_item;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(66, 388);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // ShowLecturers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(button_Add);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "ShowLecturers";
            Text = "ShowLecturers";
            Load += ShowLecturers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button_Add;
    }
}