using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserManager
    {
        public static bool CreateUser(string username, string password, int type)
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

        public static bool UpgradeUser(int userId)
        {
            throw new NotImplementedException();
        }


        public static bool LoginUser(string username, string password)
        {
            using (var db = new YouTubeUMLEntities())
            {
                User user = db.Users.FirstOrDefault(el => el.UserName.Equals(username) && el.Password.Equals(password));
                if (user == null)
                    return false;
            
            }
            return true;
        }


    }
}
