namespace University
{
    partial class Join_in_student
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userName_input = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // userName_input
            // 
            userName_input.Location = new Point(372, 171);
            userName_input.Name = "userName_input";
            userName_input.Size = new Size(140, 27);
            userName_input.TabIndex = 0;
            userName_input.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(292, 305);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 2;
            button1.Text = "join in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 148);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 3;
            label1.Text = "User name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(405, 225);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "password";
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(454, 305);
            button2.Name = "button2";
            button2.Size = new Size(128, 41);
            button2.TabIndex = 5;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(361, 33);
            label3.Name = "label3";
            label3.Size = new Size(151, 37);
            label3.TabIndex = 6;
            label3.Text = "student";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Bisque;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(29, 394);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 7;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 79);
            label4.Name = "label4";
            label4.Size = new Size(85, 27);
            label4.TabIndex = 8;
            label4.Text = "join in";
            // 
            // Join_in_student
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(900, 450);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(userName_input);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Join_in_student";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox userName_input;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label4;
    }
}
