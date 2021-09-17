using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    public class SqlConnector : IDataConnection
    {

        // TODO - make method connect to database
        /// <summary>
        /// Saves a person to the database
        /// </summary>
        /// <param name="model">Person information</param>
        /// <returns>Person information</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
