namespace WinFormsApp1
{
    partial class Alarm
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
            dateTimePicker1 = new DateTimePicker();
            Start = new Button();
            Stop = new Button();
            label1 = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(161, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Start
            // 
            Start.Location = new Point(53, 136);
            Start.Name = "Start";
            Start.Size = new Size(119, 54);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(270, 136);
            Stop.Name = "Stop";
            Stop.Size = new Size(117, 54);
            Stop.TabIndex = 2;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(214, 113);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "status";
            // 
            // Alarm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 286);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Alarm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alarm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button Start;
        private Button Stop;
        private Label label1;
        private Label lblStatus;
    }
}