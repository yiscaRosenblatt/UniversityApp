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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            titleMessages = new Label();
            buttonDate = new Button();
            buttonFavorite = new Button();
            buttonTheSender = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewComboBoxColumn();
            monthCalendar = new MonthCalendar();
            theMessages = new CheckedListBox();
            titleLecturer = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // titleMessages
            // 
            titleMessages.AutoSize = true;
            titleMessages.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleMessages.Location = new Point(331, 50);
            titleMessages.Name = "titleMessages";
            titleMessages.Size = new Size(122, 27);
            titleMessages.TabIndex = 0;
            titleMessages.Text = "Messages";
            // 
            // buttonDate
            // 
            buttonDate.Location = new Point(360, 102);
            buttonDate.Name = "buttonDate";
            buttonDate.Size = new Size(123, 39);
            buttonDate.TabIndex = 1;
            buttonDate.Text = "date";
            buttonDate.UseVisualStyleBackColor = true;
            // 
            // buttonFavorite
            // 
            buttonFavorite.Location = new Point(102, 102);
            buttonFavorite.Name = "buttonFavorite";
            buttonFavorite.Size = new Size(123, 39);
            buttonFavorite.TabIndex = 2;
            buttonFavorite.Text = "favorite";
            buttonFavorite.UseVisualStyleBackColor = true;
            // 
            // buttonTheSender
            // 
            buttonTheSender.Location = new Point(231, 102);
            buttonTheSender.Name = "buttonTheSender";
            buttonTheSender.Size = new Size(123, 39);
            buttonTheSender.TabIndex = 3;
            buttonTheSender.Text = "alphabetical";
            buttonTheSender.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 114);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 4;
            label2.Text = "sort by>";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.Grip;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Format = "C3";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = Color.Cyan;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.GridColor = Color.FromArgb(255, 192, 192);
            dataGridView1.Location = new Point(93, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(0, 8);
            dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DividerWidth = 9;
            Column4.HeaderText = "מה קורה כאן";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(516, 13);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 16;
            monthCalendar.DateChanged += monthCalendar1_DateChanged;
            // 
            // theMessages
            // 
            theMessages.FormatString = "d";
            theMessages.FormattingEnabled = true;
            theMessages.Items.AddRange(new object[] { "staff meeting", "check tests", "A zoom lesson instead of a face-to-face lesson", "International conference of lecturers", "Formation of lecturers" });
            theMessages.Location = new Point(21, 159);
            theMessages.Name = "theMessages";
            theMessages.Size = new Size(483, 136);
            theMessages.TabIndex = 17;
            theMessages.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // titleLecturer
            // 
            titleLecturer.AutoSize = true;
            titleLecturer.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLecturer.Location = new Point(305, 13);
            titleLecturer.Name = "titleLecturer";
            titleLecturer.Size = new Size(167, 37);
            titleLecturer.TabIndex = 18;
            titleLecturer.Text = "lecturer";
            titleLecturer.Click += label3_Click;
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
            // Messages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 522);
            Controls.Add(button1);
            Controls.Add(titleLecturer);
            Controls.Add(theMessages);
            Controls.Add(monthCalendar);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(buttonTheSender);
            Controls.Add(buttonFavorite);
            Controls.Add(buttonDate);
            Controls.Add(titleMessages);
            Cursor = Cursors.AppStarting;
            Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Messages";
            Text = "Messages";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleMessages;
        private Button buttonDate;
        private Button buttonFavorite;
        private Button buttonTheSender;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewCheckBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewComboBoxColumn Column4;
        private MonthCalendar monthCalendar;
        private CheckedListBox theMessages;
        private Label titleLecturer;
        private Button button1;
    }
}