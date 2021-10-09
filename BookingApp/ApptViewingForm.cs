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
        List<DisplayModel> appts = new List<DisplayModel>();

        public ApptViewingForm()
        {
            InitializeComponent();
            CreateSchedule();
            cbAppointments.ItemHeight *= 3;

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
            if (e.Index > -1)
            {
                var name = appts[e.Index].FullName;
                var service = appts[e.Index].ServiceName;
                var timeslot = appts[e.Index].TimeSlotName;
                var phone = appts[e.Index].PhoneNumber;
                string divider = "- - - - - - - - - - - - - - - - ";

                if ((e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit)
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                else if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                    e.Graphics.FillRectangle(SystemBrushes.InactiveCaption, e.Bounds);
                else
                    e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);

         
                e.Graphics.DrawString(timeslot,
                    new Font(this.cbAppointments.Font, FontStyle.Regular),
                    Brushes.Black,
                    new Rectangle(e.Bounds.Left, e.Bounds.Top,
                        e.Bounds.Width, this.cbAppointments.ItemHeight / 2));

                e.Graphics.DrawString(name,
                    this.cbAppointments.Font,
                    Brushes.Black,
                    new Rectangle(e.Bounds.Left + e.Bounds.Width / 2, e.Bounds.Top,
                        e.Bounds.Width / 2, this.cbAppointments.ItemHeight / 2), new StringFormat(StringFormatFlags.DirectionRightToLeft));

                e.Graphics.DrawString(string.Format("{0}", phone),
                    this.cbAppointments.Font,
                    Brushes.DarkSlateGray,
                    new Rectangle(e.Bounds.Left, e.Bounds.Top + this.cbAppointments.ItemHeight / 3,
                        e.Bounds.Width / 2, this.cbAppointments.ItemHeight / 2));


                e.Graphics.DrawString(string.Format("{0}", service),
                    this.cbAppointments.Font,
                    Brushes.DarkSlateGray,
                    new Rectangle(e.Bounds.Left + e.Bounds.Width / 2,
                        e.Bounds.Top + this.cbAppointments.ItemHeight / 3,
                        e.Bounds.Width/2, this.cbAppointments.ItemHeight / 2), new StringFormat(StringFormatFlags.DirectionRightToLeft));

                e.Graphics.DrawString(string.Format("{0}{1}", divider, divider),
                   this.cbAppointments.Font,
                   Brushes.DarkSlateGray,
                   new Rectangle(e.Bounds.Left ,
                       e.Bounds.Top + 2*this.cbAppointments.ItemHeight/3 ,
                       e.Bounds.Width , 2 * this.cbAppointments.ItemHeight / 3));
            }
        }
    }
}
