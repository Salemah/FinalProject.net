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
            return new AdminAppointmentRepo(db);
        }
        public static AdminIRepo<Notice, int> GetNoticeDataAccess()
        {
            return new AdminNoticeRepo(db);
        }
        public static AdminIRepo<Epatient, int> GetEpatientDataAccess()
        {
            return new AdminEpatientRepo(db);
        }
        public static AdminIRepo<Registration, int> GetUserDataAccess()
        {
            return new AdminUserRepo(db);
        }
        public static AdmindoctorRepo<Registration, int> GetDoctorDataAccess()
        {
            return new AdminUserRepo(db);
        }
        public static AdminpPatientRepo<Registration, int> GetPatientDataAccess()
        {
            return new AdminUserRepo(db);
        }

    }
}
