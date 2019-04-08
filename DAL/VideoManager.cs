using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public static bool DislikeVideo(int id)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Video video = db.Videos.FirstOrDefault(el => el.Id == id);
                video.Dislikes = ++video.Dislikes;
                db.SaveChanges();
            }

            return true;
        }

        public static bool CommentVideo(int vid, string msg, int uid)
        {
            using (var db = new YouTubeUMLEntities())
            {
                if(db.Videos.FirstOrDefault(el => el.Id == vid) != null)
                {
                    Comment comment = new Comment();

                    comment.Message = msg;
                    comment.UserId = uid;
                    comment.VideoId = vid;

                    db.Comments.Add(comment);
                    db.SaveChanges();
                }
            }

            return true;
        }

        public static string GetComments(int vid)
        {
            var list = new List<Comment>();
            string result;
            using (var db = new YouTubeUMLEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                list = db.Comments.Where(el => el.VideoId == vid).OrderByDescending(x => x.Id).ToList();
                result = JsonConvert.SerializeObject(list, Formatting.Indented);
            }

            return result;
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

        public static int GetVideoLikes(int id)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Video video = db.Videos.FirstOrDefault(el => el.Id == id);
                if (video != null)
                    return (int)video.Likes;
            }

            return 0;
        }

        public static int GetVideoDislikes(int id)
        {
            using (var db = new YouTubeUMLEntities())
            {
                Video video = db.Videos.FirstOrDefault(el => el.Id == id);
                if (video != null)
                    return (int)video.Dislikes;
            }

            return 0;
        }

       
    }
}
