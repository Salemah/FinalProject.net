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
    public class AdminEpatientService
    {
        public static List<AdminEpatientModel> Get()      //get all
        {
            var data = DataAccessFactory.GetEpatientDataAccess().Get();
            var adata = new List<AdminEpatientModel>();
            foreach (var item in data)
            {
                adata.Add(new AdminEpatientModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Age = item.Age,
                    Gender = item.Gender,
                    Email = item.Email,
                    Phone_no = item.Phone_no,
                    Type = item.Type,
                    Blood_group = item.Blood_group,
                    Checked = item.Checked

                  
                   
                });
            }
            return adata;
        }
        public static List<Epatient> GetVariableCount(int count)
        {
            return DataAccessFactory.GetEpatientDataAccess().Get().Take(count).ToList();
        }
        public static AdminEpatientModel GetOnly(int id)      //get one
        {
            var item = DataAccessFactory.GetEpatientDataAccess().Get(id);
            if (item != null)
            {
                var a = new AdminEpatientModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Age = item.Age,
                    Gender = item.Gender,
                    Email = item.Email,
                    Phone_no = item.Phone_no,
                    Type = item.Type,
                    Blood_group = item.Blood_group,
                    Checked = item.Checked
                };
                return a;
            }
            return null;
        }
        public static bool Create(AdminEpatientModel item)        //create
        {
            var epatient = new Epatient()
            {
                Id = item.Id,
                Name = item.Name,
                Age = item.Age,
                Gender = item.Gender,
                Email = item.Email,
                Phone_no = item.Phone_no,
                Type = item.Type,
                Blood_group = item.Blood_group,
                Checked = item.Checked
            };
            return DataAccessFactory.GetEpatientDataAccess().Create(epatient);
        }
        public static bool Update(AdminEpatientModel item)        //update
        {
            var epatient = new Epatient()
            {
                Id = item.Id,
                Name = item.Name,
                Age = item.Age,
                Gender = item.Gender,
                Email = item.Email,
                Phone_no = item.Phone_no,
                Type = item.Type,
                Blood_group = item.Blood_group,
                Checked = item.Checked
            };
            return DataAccessFactory.GetEpatientDataAccess().Update(epatient);
        }
        public static bool Delete(int id)       //delete
        {
            return DataAccessFactory.GetEpatientDataAccess().Delete(id);
        }

    }
}
