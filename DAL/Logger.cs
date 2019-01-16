using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Logger
    {
        public static bool AddLog(string action, int uid){
            using (var db = new YouTubeUMLEntities())
            {
                var log = new Log();
                db.Logs.Add(log);
                log.Action = action;
                log.UserId = uid;
                log.Type = 1;

                db.SaveChanges();
            }
            return true;
        }
    }
}
