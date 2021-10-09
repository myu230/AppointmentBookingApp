using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    public class DisplayModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Person who is in the appt slot.
        /// </summary>
        public string FirstName { get; set; }
        /// </summary>
        public string LastName { get; set; }
  
        public string TimeSlotName { get; set; }

        /// <summary>
        /// Type of appt.
        /// </summary>
        public string ServiceName { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{TimeSlotName}: {FirstName} {LastName}              {ServiceName}";
            }
        }
    }
}
