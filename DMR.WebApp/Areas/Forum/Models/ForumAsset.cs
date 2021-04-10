using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Forum.Models
{
    public class ForumAsset : Asset
    {
        public ForumGroup Group { get; set; }
        public string Url { get; set; }
    }


    public enum ForumGroup
    {
        News = 1,
        Community,
        Feedback
    }
}
