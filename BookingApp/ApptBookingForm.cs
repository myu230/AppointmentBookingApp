using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BookingLibrary;

namespace BookingApp
{
    public partial class ApptBookingForm : Form
    {
        public ApptBookingForm()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtNameFirst.TextLength > 0 && txtNameLast.TextLength > 0  && txtPhone.TextLength > 0)
            {
                btnSubmit.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel model = new PersonModel();

                model.FirstName = txtNameFirst.Text;
                model.LastName = txtNameLast.Text;
                model.Email = txtEmail.Text;
                model.PhoneNumber = txtPhone.Text;

                GlobalConfig.Connection.CreatePerson(model);
                
                MessageBox.Show("Thank You!", "Booking Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            
            if (!Regex.Match(txtNameFirst.Text, @"^[A-Z][\s-a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameFirst.Focus();
                output = false;
            }
            if (!Regex.Match(txtNameLast.Text, @"^[A-Z][\s-a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameLast.Focus();
                output = false;
            }
            if (!Regex.Match(txtPhone.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
            {
                MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                output = false;
            }
            if (!Regex.Match(txtEmail.Text, @"^[\w\._-]+@[\w]+\.[\w]+$").Success)
            {
                MessageBox.Show("Invalid email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                output = false;
            }

            return output;
        }

        private void ClearForm()
        {
            txtNameFirst.Clear();
            txtNameLast.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtNameFirst.Focus();
        }
    }
}
