using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VideoManager
    {
        public static Video GetVideo(int id)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Video video = db.Videos.FirstOrDefault(el => el.Id == id) ?? new NullVideo();
                return video;
            }
        }

        public static bool UploadVideo(string name, int userId, string URL)
        {
            using (var db = new YouTubeUMLEntities())
            {
                var video = new Video();
                db.Videos.Add(video);
                video.Title = name;
                video.URL = URL;
                video.UploaderId = userId;

                db.SaveChanges();
            }
            return true;
        }

        public static bool LikeVideo(int id)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Video video = db.Videos.FirstOrDefault(el => el.Id == id);
                video.Likes = ++video.Likes;
                db.SaveChanges();
            }

            return true;
        }

        public static bool UnlikeVideo(int id)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Video video = db.Videos.FirstOrDefault(el => el.Id == id);
                video.Likes = --video.Likes;
                db.SaveChanges();
            }

            return true;
        }

        public static bool CommentVideo(int vid, string msg, int uid)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Comment comment = new Comment();

                comment.Message = msg;
                comment.UserId = uid;
                comment.VideoId = vid;

                db.SaveChanges();
            }

            return true;
        }

        public static List<Comment> GetComments(int vid)
        {
            using (var db = new YouTubeUMLEntities())
            {
                return db.Comments.Where(el => el.VideoId == vid).ToList();
            }
        }

        public static bool DeleteVideo(int id)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Video video = db.Videos.FirstOrDefault(el => el.Id == id);
                if (video != null)
                {
                    db.Videos.Remove(video);
                    db.SaveChanges();
                }
            }

            return true;
        }
    }
}
