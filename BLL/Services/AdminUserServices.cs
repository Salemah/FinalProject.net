using BLL.BOs;
using DLL;
using DLL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
   public  class AdminUserServices
    {

        public static List<AdminRegistrationModel> Get()      //get all
        {
            var data = DataAccessFactory.GetUserDataAccess().Get();
            var adata = new List<AdminRegistrationModel>();
            foreach (var item in data)
            {
                adata.Add(new AdminRegistrationModel()
                {
                    Id = item.Id,
                   Name = item.Name,
                    Password = item.Password,
                   Age = item.Age,
                    Gender = item.Gender,
                    Email = item.Email,
                   Phone_no = item.Phone_no,
                    Blood_group = item.Blood_group,
                    Type = item.Type,
                    Salary = item.Salary,
                    Department = item.Department,
                    Degree = item.Degree
                });
            }
            return adata;
        }
        public static AdminRegistrationModel GetOnly(int id)      //get one
        {
            var item = DataAccessFactory.GetUserDataAccess().Get(id);
            if (item != null)
            {
                var s = new AdminRegistrationModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Age = item.Age,
                    Gender = item.Gender,
                    Email = item.Email,
                    Phone_no = item.Phone_no,
                    Blood_group = item.Blood_group,
                    Type = item.Type,
                    Salary = item.Salary,
                    Department = item.Department,
                    Degree = item.Degree
                };
                return s;
            }
            return null;
        }
        public static bool Create(AdminRegistrationModel item)        //create
        {
            var registration = new Registration()
            {
                Id = item.Id,
                Name = item.Name,
                Password = item.Password,
                Age = item.Age,
                Gender = item.Gender,
                Email = item.Email,
                Phone_no = item.Phone_no,
                Blood_group = item.Blood_group,
                Type = item.Type,
                Salary = item.Salary,
                Department = item.Department,
                Degree = item.Degree
            };
            return DataAccessFactory.GetUserDataAccess().Create(registration);
        }
        public static bool Update(AdminRegistrationModel item)        //update
        {
            var regiter = new Registration()
            {
                Id = item.Id,
                Name = item.Name,
                Password = item.Password,
                Age = item.Age,
                Gender = item.Gender,
                Email = item.Email,
                Phone_no = item.Phone_no,
                Blood_group = item.Blood_group,
                Type = item.Type,
                Salary = item.Salary,
                Department = item.Department,
                Degree = item.Degree
            };
            return DataAccessFactory.GetUserDataAccess().Update(regiter);
        }
        public static bool Delete(int id)       //delete
        {
            return DataAccessFactory.GetUserDataAccess().Delete(id);
        }
        public static List<AdminRegistrationModel> Getdoc()      //get all
        {
            var data = DataAccessFactory.GetDoctorDataAccess().Getdoc();
            var adata = new List<AdminRegistrationModel>();
       
            foreach (var item in data)
            {
                adata.Add(new AdminRegistrationModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Age = item.Age,
                    Gender = item.Gender,
                    Email = item.Email,
                    Phone_no = item.Phone_no,
                    Blood_group = item.Blood_group,
                    Type = item.Type,
                    Salary = item.Salary,
                    Department = item.Department,
                    Degree = item.Degree

                });
            }
            return adata;
        }

        public static int Dcccount()      //get all
        {
            return  DataAccessFactory.GetDoctorDataAccess().Dcccount();
        

           
        }
        public static int Usscount()      //get all
        {
            return DataAccessFactory.GetUsscountDataAccess().Usscount();



        }
        public static int Patientcount()      //get all
        {
            return DataAccessFactory.GetPatientDataAccess().Patientcount();



        }





        public static List<AdminRegistrationModel> GetPatient()      //get all
        {
            var data = DataAccessFactory.GetPatientDataAccess().GetPatient();
            var adata = new List<AdminRegistrationModel>();
            foreach (var item in data)
            {
                adata.Add(new AdminRegistrationModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Age = item.Age,
                    Gender = item.Gender,
                    Email = item.Email,
                    Phone_no = item.Phone_no,
                    Blood_group = item.Blood_group,
                    Type = item.Type,
                   
                });
            }
            return adata;
        }


    }
}
