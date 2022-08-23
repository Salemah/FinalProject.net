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

        public static AdminIRepo<Appointment, int> GetAppointmentDataAccess()
        {
            return new AppointmentRepo(db);
        }
        public static AdminIRepo<Notice, int> GetNoticeDataAccess()
        {
            return new NoticeRepo(db);
        }
        public static AdminIRepo<Epatient, int> GetEpatientDataAccess()
        {
            return new EpatientRepo(db);
        }
        public static AdminIRepo<Registration, int> GetUserDataAccess()
        {
            return new UserRepo(db);
        }
        public static AdmindoctorRepo<Registration, int> GetDoctorDataAccess()
        {
            return new UserRepo(db);
        }
        public static AdminpPatientRepo<Registration, int> GetPatientDataAccess()
        {
            return new UserRepo(db);
        }

    }
}
