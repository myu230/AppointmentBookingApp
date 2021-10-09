
namespace BookingApp
{
    partial class ApptViewingForm
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
            this.cbAppointments = new System.Windows.Forms.ComboBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.btnCreateAppt = new System.Windows.Forms.Button();
            this.btnDelAppt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAppointments
            // 
            this.cbAppointments.BackColor = System.Drawing.SystemColors.Window;
            this.cbAppointments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAppointments.FormattingEnabled = true;
            this.cbAppointments.Location = new System.Drawing.Point(288, 33);
            this.cbAppointments.MaxDropDownItems = 5;
            this.cbAppointments.Name = "cbAppointments";
            this.cbAppointments.Size = new System.Drawing.Size(223, 289);
            this.cbAppointments.TabIndex = 0;
            this.cbAppointments.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbAppointments_DrawItem);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(31, 33);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // btnCreateAppt
            // 
            this.btnCreateAppt.Location = new System.Drawing.Point(31, 221);
            this.btnCreateAppt.Name = "btnCreateAppt";
            this.btnCreateAppt.Size = new System.Drawing.Size(227, 47);
            this.btnCreateAppt.TabIndex = 4;
            this.btnCreateAppt.Text = "Create New Appointment";
            this.btnCreateAppt.UseVisualStyleBackColor = true;
            this.btnCreateAppt.Click += new System.EventHandler(this.btnCreateAppt_Click);
            // 
            // btnDelAppt
            // 
            this.btnDelAppt.Location = new System.Drawing.Point(31, 275);
            this.btnDelAppt.Name = "btnDelAppt";
            this.btnDelAppt.Size = new System.Drawing.Size(227, 47);
            this.btnDelAppt.TabIndex = 5;
            this.btnDelAppt.Text = "Delete Appointment";
            this.btnDelAppt.UseVisualStyleBackColor = true;
            // 
            // ApptViewingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 357);
            this.Controls.Add(this.btnDelAppt);
            this.Controls.Add(this.btnCreateAppt);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.cbAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApptViewingForm";
            this.Text = "ApptViewingForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button btnCreateAppt;
        private System.Windows.Forms.Button btnDelAppt;
        public System.Windows.Forms.ComboBox cbAppointments;
    }
}