namespace PodborPersonala
{
    partial class Decision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decision));
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertButton_Appoint = new System.Windows.Forms.Button();
            this.InsertButton_Reject = new System.Windows.Forms.Button();
            this.InterviewdatePicker = new System.Windows.Forms.DateTimePicker();
            this.TypeOfInterviewcomboBox = new System.Windows.Forms.ComboBox();
            this.EmployeecomboBox = new System.Windows.Forms.ComboBox();
            this.InterviewStatuscomboBox = new System.Windows.Forms.ComboBox();
            this.CandidatescomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InterviewtimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(627, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(27, 25);
            this.labelClose.TabIndex = 9;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Кандидат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Решение о собеседовании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата собеседования:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Тип собеседования:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сотрудник:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Статус собеседования:";
            // 
            // InsertButton_Appoint
            // 
            this.InsertButton_Appoint.BackColor = System.Drawing.Color.DarkGray;
            this.InsertButton_Appoint.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.InsertButton_Appoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton_Appoint.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertButton_Appoint.ForeColor = System.Drawing.Color.Black;
            this.InsertButton_Appoint.Location = new System.Drawing.Point(166, 334);
            this.InsertButton_Appoint.Name = "InsertButton_Appoint";
            this.InsertButton_Appoint.Size = new System.Drawing.Size(152, 40);
            this.InsertButton_Appoint.TabIndex = 26;
            this.InsertButton_Appoint.Text = "Назначить";
            this.InsertButton_Appoint.UseVisualStyleBackColor = false;
            this.InsertButton_Appoint.Click += new System.EventHandler(this.InsertButton_Appoint_Click);
            this.InsertButton_Appoint.MouseEnter += new System.EventHandler(this.InsertButton_Appoint_MouseEnter);
            this.InsertButton_Appoint.MouseLeave += new System.EventHandler(this.InsertButton_Appoint_MouseLeave);
            // 
            // InsertButton_Reject
            // 
            this.InsertButton_Reject.BackColor = System.Drawing.Color.DarkGray;
            this.InsertButton_Reject.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.InsertButton_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton_Reject.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertButton_Reject.ForeColor = System.Drawing.Color.Black;
            this.InsertButton_Reject.Location = new System.Drawing.Point(342, 334);
            this.InsertButton_Reject.Name = "InsertButton_Reject";
            this.InsertButton_Reject.Size = new System.Drawing.Size(152, 40);
            this.InsertButton_Reject.TabIndex = 27;
            this.InsertButton_Reject.Text = "Отклонить";
            this.InsertButton_Reject.UseVisualStyleBackColor = false;
            this.InsertButton_Reject.Click += new System.EventHandler(this.InsertButton_Reject_Click);
            this.InsertButton_Reject.MouseEnter += new System.EventHandler(this.InsertButton_Reject_MouseEnter);
            this.InsertButton_Reject.MouseLeave += new System.EventHandler(this.InsertButton_Reject_MouseLeave);
            // 
            // InterviewdatePicker
            // 
            this.InterviewdatePicker.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.InterviewdatePicker.CustomFormat = "yyyy-MM-dd";
            this.InterviewdatePicker.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InterviewdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InterviewdatePicker.Location = new System.Drawing.Point(450, 146);
            this.InterviewdatePicker.Name = "InterviewdatePicker";
            this.InterviewdatePicker.Size = new System.Drawing.Size(204, 21);
            this.InterviewdatePicker.TabIndex = 28;
            // 
            // TypeOfInterviewcomboBox
            // 
            this.TypeOfInterviewcomboBox.BackColor = System.Drawing.Color.DimGray;
            this.TypeOfInterviewcomboBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfInterviewcomboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.TypeOfInterviewcomboBox.FormattingEnabled = true;
            this.TypeOfInterviewcomboBox.Location = new System.Drawing.Point(450, 205);
            this.TypeOfInterviewcomboBox.Name = "TypeOfInterviewcomboBox";
            this.TypeOfInterviewcomboBox.Size = new System.Drawing.Size(204, 21);
            this.TypeOfInterviewcomboBox.TabIndex = 29;
            // 
            // EmployeecomboBox
            // 
            this.EmployeecomboBox.BackColor = System.Drawing.Color.DimGray;
            this.EmployeecomboBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeecomboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EmployeecomboBox.FormattingEnabled = true;
            this.EmployeecomboBox.Location = new System.Drawing.Point(450, 235);
            this.EmployeecomboBox.Name = "EmployeecomboBox";
            this.EmployeecomboBox.Size = new System.Drawing.Size(204, 21);
            this.EmployeecomboBox.TabIndex = 30;
            // 
            // InterviewStatuscomboBox
            // 
            this.InterviewStatuscomboBox.BackColor = System.Drawing.Color.DimGray;
            this.InterviewStatuscomboBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InterviewStatuscomboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.InterviewStatuscomboBox.FormattingEnabled = true;
            this.InterviewStatuscomboBox.Location = new System.Drawing.Point(450, 266);
            this.InterviewStatuscomboBox.Name = "InterviewStatuscomboBox";
            this.InterviewStatuscomboBox.Size = new System.Drawing.Size(204, 21);
            this.InterviewStatuscomboBox.TabIndex = 31;
            // 
            // CandidatescomboBox
            // 
            this.CandidatescomboBox.BackColor = System.Drawing.Color.DimGray;
            this.CandidatescomboBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CandidatescomboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CandidatescomboBox.FormattingEnabled = true;
            this.CandidatescomboBox.Location = new System.Drawing.Point(450, 116);
            this.CandidatescomboBox.Name = "CandidatescomboBox";
            this.CandidatescomboBox.Size = new System.Drawing.Size(204, 21);
            this.CandidatescomboBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = "Время собеседования:";
            // 
            // InterviewtimePicker
            // 
            this.InterviewtimePicker.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.InterviewtimePicker.CustomFormat = "HH:mm";
            this.InterviewtimePicker.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InterviewtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InterviewtimePicker.Location = new System.Drawing.Point(450, 175);
            this.InterviewtimePicker.Name = "InterviewtimePicker";
            this.InterviewtimePicker.Size = new System.Drawing.Size(204, 21);
            this.InterviewtimePicker.TabIndex = 34;
            this.InterviewtimePicker.Value = new System.DateTime(2024, 5, 14, 23, 26, 0, 0);
            // 
            // Decision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(666, 386);
            this.Controls.Add(this.InterviewtimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CandidatescomboBox);
            this.Controls.Add(this.InterviewStatuscomboBox);
            this.Controls.Add(this.EmployeecomboBox);
            this.Controls.Add(this.TypeOfInterviewcomboBox);
            this.Controls.Add(this.InterviewdatePicker);
            this.Controls.Add(this.InsertButton_Reject);
            this.Controls.Add(this.InsertButton_Appoint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Decision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertButton_Appoint;
        private System.Windows.Forms.Button InsertButton_Reject;
        private System.Windows.Forms.DateTimePicker InterviewdatePicker;
        private System.Windows.Forms.ComboBox TypeOfInterviewcomboBox;
        private System.Windows.Forms.ComboBox EmployeecomboBox;
        private System.Windows.Forms.ComboBox InterviewStatuscomboBox;
        private System.Windows.Forms.ComboBox CandidatescomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker InterviewtimePicker;
    }
}