using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NullVideo : Video
    {
        public int Id { get => -1; }
        public string Title { get => "DefaultVideo";  }
        public string URL { get => "http://localhost/YouTubeUML/Home/Index"; }
        public Nullable<int> Likes { get => 0; }
        public Nullable<int> Dislikes { get => 0; }
        public Nullable<int> Views { get => 0; }
        public int UploaderId { get => -1; }
    }
}