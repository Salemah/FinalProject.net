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
    public class NoticeService
    {
        public static List<AdminNoticeModel> Get()      //get all
        {
            var data = DataAccessFactory.GetNoticeDataAccess().Get();
            var adata = new List<AdminNoticeModel>();
            foreach (var item in data)
            {
                adata.Add(new AdminNoticeModel()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Details = item.Details,
                    Type = item.Type
                });
            }
            return adata;
        }
        public static List<Notice> GetVariableCount(int count)
        {
            return DataAccessFactory.GetNoticeDataAccess().Get().Take(count).ToList();
        }
        public static AdminNoticeModel GetOnly(int id)      //get one
        {
            var item = DataAccessFactory.GetNoticeDataAccess().Get(id);
            if (item != null)
            {
                var a = new AdminNoticeModel()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Details = item.Details,
                    Type = item.Type
                };
                return a;
            }
            return null;
        }
        public static bool Create(AdminNoticeModel item)        //create
        {
            var notice = new Notice()
            {
                Id = item.Id,
                Title = item.Title,
                Details = item.Details,
                Type = item.Type
            };
            return DataAccessFactory.GetNoticeDataAccess().Create(notice);
        }

        public static bool Update(AdminNoticeModel item)        //update
        {
            var notice = new Notice()
            {
                Id = item.Id,
                Title = item.Title,
                Details = item.Details,
                Type = item.Type
            };
            return DataAccessFactory.GetNoticeDataAccess().Update(notice);
        }
        public static bool Delete(int id)       //delete
        {
            return DataAccessFactory.GetNoticeDataAccess().Delete(id);
        }

    }
}
