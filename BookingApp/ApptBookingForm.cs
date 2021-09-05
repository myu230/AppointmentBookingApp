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
            txtNameFirst.Clear();
            txtNameLast.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtNameFirst.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(txtNameFirst.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameFirst.Focus();
                return;
            }
            if (!Regex.Match(txtNameLast.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameLast.Focus();
                return;
            }
            if (!Regex.Match(txtPhone.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
            {
                MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (!Regex.Match(txtEmail.Text, @"^[\w\._-]+@[\w]+\.[\w]+$").Success)
            {
                MessageBox.Show("Invalid email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            MessageBox.Show("Thank You!", "Booking Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
