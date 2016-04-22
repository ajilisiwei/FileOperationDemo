using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEI_DAL;

namespace WEIService
{
    public class UserService
    {
        billiardEntities1 context = new billiardEntities1();
  
        public string GetUserName()
        {
            var test = context.UserInfo.Where(u=>u.UserName=="admin").FirstOrDefault();
            return test.ToString();
        }

        public bool AddUser()
        {
            UserInfo userinfo = new UserInfo();
            userinfo.Name = "wei";
            userinfo.UserName = "wei";
            context.UserInfo.Add(userinfo);
            if (context.SaveChanges() > 0) return true;
            else return false;
        }

    }
}
