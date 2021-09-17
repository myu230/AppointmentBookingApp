using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    public class DayModel
    {
        /// <summary>
        /// One full schedule day.
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Appointments made on set date.
        /// </summary>
        public List<ApptModel> Schedule { get; set; }
    }
}
