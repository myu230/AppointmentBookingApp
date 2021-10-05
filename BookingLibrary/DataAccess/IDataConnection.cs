using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    public interface IDataConnection
    {
        PersonModel CreatePerson(PersonModel model);

        List<TimeSlotModel> GetTimeSlots_All();

        List <TimeSlotModel> GetTimeSlots_Avail(string appDate);
    }
}
