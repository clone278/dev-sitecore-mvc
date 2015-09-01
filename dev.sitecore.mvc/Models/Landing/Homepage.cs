using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using dev.sitecore.mvc.Models.Content;

namespace dev.sitecore.mvc.Models.Landing
{
    public class Homepage
    {
        public virtual string Title {get; set;}
        public virtual string MainBody {get; set;}
        public virtual IEnumerable<NewsArticle> News { get; set; }
    }
}