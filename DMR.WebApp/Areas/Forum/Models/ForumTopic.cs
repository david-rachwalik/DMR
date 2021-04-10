using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Forum.Models
{
    public class ForumTopic : Asset
    {
        public IEnumerable<ForumPost> Posts { get; set; }
    }
}
