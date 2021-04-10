using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Blog.Models
{
    public class BlogPost : Asset
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
    }
}
