using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using dev.sitecore.mvc.Models.Misc;

namespace dev.sitecore.mvc.Models.Content
{
    [SitecoreType]
    public class NewsArticle: ContentBase
    {
        
        [SitecoreField]
        public virtual string Abstract { get; set; }

        [SitecoreField]
        public virtual string MainBody { get; set; }

        [SitecoreField]
        public virtual Image FeaturedImage { get; set; }

        [SitecoreField]
        public virtual DateTime Date { get; set; }

    }
}