﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    public class TextConnector : IDataConnection
    {
        public ApptModel CreateAppt(ApptModel appt, PersonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Connect method to textfile
        public PersonModel CreatePerson(PersonModel model)
        {
            model.Id = 1;

            return model;
        }

        public List<string> GetServices()
        {
            throw new NotImplementedException();
        }

        public List<TimeSlotModel> GetTimeSlots_All()
        {
            throw new NotImplementedException();
        }

        public List<TimeSlotModel> GetTimeSlots_Avail(string appDate)
        {
            throw new NotImplementedException();
        }
    }
}
