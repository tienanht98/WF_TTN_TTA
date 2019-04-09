using System;
using System.Linq;
using WF_TTN_TTA.DataLayer;
using WF_TTN_TTA.Model;
namespace WF_TTN_TTA.Dao
{

    class UserDao
    {
        QLHSTHPT db = null;
        public UserDao()
        {
            db = new QLHSTHPT();
        }
        public String insert(NGUOIDUNG entity)
        {
            db.NGUOIDUNGs.Add(entity);
            db.SaveChanges();
            return entity.MaND;
        }
        public NGUOIDUNG login(string username,string pass)
        {
            return db.NGUOIDUNGs.SingleOrDefault(x=> x.TenDNhap==username&&x.MatKhau==pass);
        }
    }
}
