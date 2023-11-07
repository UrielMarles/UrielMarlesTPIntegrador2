namespace RENT_A_TRONIC
{
    partial class StartFrm
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
            monthCalendar1 = new MonthCalendar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Control;
            monthCalendar1.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.Location = new Point(243, 222);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(2023, 11, 3, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.TabIndex = 0;
            // 
            // StartFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 496);
            Controls.Add(monthCalendar1);
            Name = "StartFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RENT-A-TRONIC";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}