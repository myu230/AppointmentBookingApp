﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@FirstName nvarchar(100),
//@LastName nvarchar(100),
//@Email nvarchar(100),
//@PhoneNumber nvarchar(20),
//@id int = 0 output

namespace BookingLibrary
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Appointments";
        /// <summary>
        /// Saves a person to the database
        /// </summary>
        /// <param name="model">Person information</param>
        /// <returns>Person information</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName ", model.LastName);
                p.Add("@Email", model.Email);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public List<TimeSlotModel> GetTimeSlots_All()
        {
            List<TimeSlotModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TimeSlotModel>("dbo.spTimeSlots_GetAll").ToList();
            }

            return output;
        }

        public List<TimeSlotModel> GetTimeSlots_Avail(string appDate)
        {
            List<TimeSlotModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var val = new { AppDate = appDate };
                output = connection.Query<TimeSlotModel>("dbo.spTimeSlots_GetByDate @AppDate",val).ToList();
            }

            return output;
        }
    }
}
