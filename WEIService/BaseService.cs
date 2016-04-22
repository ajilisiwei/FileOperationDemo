using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_DAL;

namespace WEIService
{
    public class BaseService<TModel> where
        TModel:class,new()
    {
        public  billiardEntities1 _context = new billiardEntities1();
        public void Add(TModel entities)
        {
            try 
            {
                using (_context)
                {
                    UserInfo userinfo = new UserInfo();
                    userinfo.UserName = "weiwei";
                    _context.Entry<UserInfo>(userinfo).State = EntityState.Added;
                    _context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
            }
        }
    }
}
