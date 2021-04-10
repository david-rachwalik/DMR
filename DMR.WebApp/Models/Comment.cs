using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Models
{
    public class Comment : Asset
    {
        public CommentStyle Style { get; set; }
        public string Content { get; set; }
        public int Parent { get; set; }
        //public IEnumerable<ApplicationUser> VoteUp { get; set; }
        //public IEnumerable<ApplicationUser> VoteDown { get; set; }
    }
    

    public enum CommentStyle
    {
        Simple = 1,
        Announcement,
        BlogSection,
        BlogPost,
        ForumPost,
        Moderator
    }
}
