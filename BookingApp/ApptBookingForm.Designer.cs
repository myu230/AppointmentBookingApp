
namespace BookingApp
{
    partial class ApptBookingForm
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
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNameFirst = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNameLast = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(161, 164);
            this.txtDate.MaxDate = new System.DateTime(3021, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(2020, 9, 16, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(156, 20);
            this.txtDate.TabIndex = 9;
            this.txtDate.Value = new System.DateTime(2021, 9, 16, 0, 0, 0, 0);
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbTime.Location = new System.Drawing.Point(161, 200);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(156, 21);
            this.cbTime.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 166);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(15, 202);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 16);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time:";
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirst.Location = new System.Drawing.Point(15, 22);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(76, 16);
            this.lblNameFirst.TabIndex = 0;
            this.lblNameFirst.Text = "First Name:";
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLast.Location = new System.Drawing.Point(15, 58);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(76, 16);
            this.lblNameLast.TabIndex = 2;
            this.lblNameLast.Text = "Last Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(15, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 16);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.Location = new System.Drawing.Point(161, 20);
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.Size = new System.Drawing.Size(156, 20);
            this.txtNameFirst.TabIndex = 1;
            this.txtNameFirst.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtNameLast
            // 
            this.txtNameLast.Location = new System.Drawing.Point(161, 56);
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.Size = new System.Drawing.Size(156, 20);
            this.txtNameLast.TabIndex = 3;
            this.txtNameLast.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(242, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(161, 274);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(161, 92);
            this.txtPhone.Mask = "000-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(15, 239);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(56, 16);
            this.lblSubject.TabIndex = 12;
            this.lblSubject.Text = "Subject:";
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSubject.Location = new System.Drawing.Point(161, 237);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(156, 21);
            this.cbSubject.TabIndex = 13;
            // 
            // ApptBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 317);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNameFirst);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApptBookingForm";
            this.Text = "Book an Appoinment";
            this.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNameFirst;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNameLast;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbSubject;
    }
}

