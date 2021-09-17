using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    public class PersonModel
    {
        /// <summary>
        ///  Person ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Person first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Person last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Person Email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Person Phone.
        /// </summary>
        public string PhoneNumber { get; set; }

    }
}
