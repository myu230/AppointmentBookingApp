using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    /// <summary>
    /// One appointment slot.
    /// </summary>
    public class ApptModel
    {
        /// <summary>
        /// Person who is in the appt slot.
        /// </summary>
        public PersonModel Person { get; set; }
        /// <summary>
        /// Time of appt.
        /// </summary>
        public string ApptTime { get; set; }
        /// <summary>
        /// Type of appt.
        /// </summary>
        public string Service { get; set; }
    }
}
