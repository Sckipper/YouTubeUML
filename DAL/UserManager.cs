using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserManager
    {
        public static bool CreateUser(String username, String password, int type)
        {
            using (var db = new YouTubeUMLEntities())
            {
                var user = new User();
                db.Users.Add(user);
                user.UserName = username;
                user.Password = password;
                user.Type = type;

                db.SaveChanges();
            }
            return true;
        }
    }
}
