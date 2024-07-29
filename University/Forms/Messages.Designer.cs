namespace University
{
    partial class Messages
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
            titleMessages = new Label();
            buttonDate = new Button();
            buttonFavorite = new Button();
            buttonTheSender = new Button();
            label2 = new Label();
            monthCalendar = new MonthCalendar();
            button1 = new Button();
            label1 = new Label();
            listBoxMessages = new ListBox();
            SuspendLayout();
            // 
            // titleMessages
            // 
            titleMessages.AutoSize = true;
            titleMessages.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleMessages.Location = new Point(196, 35);
            titleMessages.Name = "titleMessages";
            titleMessages.Size = new Size(181, 39);
            titleMessages.TabIndex = 0;
            titleMessages.Text = "Messages";
            titleMessages.Click += titleMessages_Click;
            // 
            // buttonDate
            // 
            buttonDate.BackColor = Color.LemonChiffon;
            buttonDate.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            buttonDate.Location = new Point(360, 102);
            buttonDate.Name = "buttonDate";
            buttonDate.Size = new Size(123, 39);
            buttonDate.TabIndex = 1;
            buttonDate.Text = "date";
            buttonDate.UseVisualStyleBackColor = false;
            // 
            // buttonFavorite
            // 
            buttonFavorite.BackColor = Color.LemonChiffon;
            buttonFavorite.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            buttonFavorite.Location = new Point(102, 102);
            buttonFavorite.Name = "buttonFavorite";
            buttonFavorite.Size = new Size(123, 39);
            buttonFavorite.TabIndex = 2;
            buttonFavorite.Text = "favorite";
            buttonFavorite.UseVisualStyleBackColor = false;
            buttonFavorite.Click += buttonFavorite_Click;
            // 
            // buttonTheSender
            // 
            buttonTheSender.BackColor = Color.LemonChiffon;
            buttonTheSender.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            buttonTheSender.Location = new Point(231, 102);
            buttonTheSender.Name = "buttonTheSender";
            buttonTheSender.Size = new Size(123, 39);
            buttonTheSender.TabIndex = 3;
            buttonTheSender.Text = "alphabetical";
            buttonTheSender.UseVisualStyleBackColor = false;
            buttonTheSender.Click += buttonTheSender_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 114);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 4;
            label2.Text = "sort by>";
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = SystemColors.Info;
            monthCalendar.Location = new Point(506, 22);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 16;
            monthCalendar.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(18, 461);
            button1.Name = "button1";
            button1.Size = new Size(127, 48);
            button1.TabIndex = 19;
            button1.Text = "back to HomePage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 209);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 21;
            // 
            // listBoxMessages
            // 
            listBoxMessages.BorderStyle = BorderStyle.FixedSingle;
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.Location = new Point(131, 161);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(336, 162);
            listBoxMessages.TabIndex = 22;
            // 
            // Messages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 522);
            Controls.Add(listBoxMessages);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(monthCalendar);
            Controls.Add(label2);
            Controls.Add(buttonTheSender);
            Controls.Add(buttonFavorite);
            Controls.Add(buttonDate);
            Controls.Add(titleMessages);
            Cursor = Cursors.AppStarting;
            Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Messages";
            Text = "Messages";
            Load += Messages_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleMessages;
        private Button buttonDate;
        private Button buttonFavorite;
        private Button buttonTheSender;
        private Label label2;
        private MonthCalendar monthCalendar;
        private Button button1;
        private Label label1;
        private ListBox listBoxMessages;
    }
}