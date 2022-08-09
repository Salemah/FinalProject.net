using DLL.EF;
using DLL.Interfaces;
using DLL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DataAccessFactory
    {
        static HospitalEntities db = new HospitalEntities();

        public static IRepo<Appointment, int> GetAppointmentDataAccess()
        {
            return new AppointmentRepo(db);
        }

    }
}
