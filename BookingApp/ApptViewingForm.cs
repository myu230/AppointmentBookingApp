using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingLibrary;

namespace BookingApp
{ 
    public partial class ApptViewingForm : Form
    {
        List<TimeSlotModel> apptList = new List<TimeSlotModel>();
      
        public ApptViewingForm()
        {
            InitializeComponent();
            CreateSchedule();
            cbAppointments.ItemHeight *= 2;

        }

        private void btnCreateAppt_Click(object sender, EventArgs e)
        {
            ApptBookingForm apptBooking = new ApptBookingForm();
            apptBooking.ShowDialog();
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            CreateSchedule();
        }

        private void CreateSchedule()
        {
            List<DisplayModel> appts = new List<DisplayModel>();

            string date = calendar.SelectionStart.ToString("d");
            apptList = GlobalConfig.Connection.GetTimeSlots_All();
            cbAppointments.DataSource = apptList;
            cbAppointments.DisplayMember = "TimeSlotName";

            appts = GlobalConfig.Connection.GetDay(date);

            cbAppointments.DataSource = appts;
            cbAppointments.DisplayMember = "FullInfo";
            cbAppointments.Text = String.Format("{0}", calendar.SelectionStart.ToLongDateString());

            //cbAppointments.DataSource = apptList;
            //cbAppointments.DisplayMember = "TimeSlotName";
            //cbAppointments.Text = String.Format("{0}", calendar.SelectionStart.ToLongDateString());

        }

        private void cbAppointments_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
