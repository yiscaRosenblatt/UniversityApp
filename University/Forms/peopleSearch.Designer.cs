namespace University
{
    partial class peopleSearch
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            people_listView = new ListView();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 18);
            label1.Name = "label1";
            label1.Size = new Size(231, 35);
            label1.TabIndex = 1;
            label1.Text = "people search";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 32);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
          
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(12, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // people_listView
            // 
            people_listView.Location = new Point(136, 121);
            people_listView.Name = "people_listView";
            people_listView.Size = new Size(470, 294);
            people_listView.TabIndex = 17;
            people_listView.UseCompatibleStateImageBehavior = false;
            people_listView.ItemActivate += clicked_user_item;
            people_listView.SelectedIndexChanged += people_listView_SelectedIndexChanged;
            // 
            // peopleSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(people_listView);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "peopleSearch";
            Text = "peopleSearch";
            Load += peopleSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private ListView people_listView;
    }
}