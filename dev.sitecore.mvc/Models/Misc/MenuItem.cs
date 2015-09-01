using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dev.sitecore.mvc.Models.Misc
{
    public class MenuItem
    {
        public virtual string Title { get; set; }

        public virtual string Url { get; set; }

        public virtual IEnumerable<MenuItem> Children { get; set; }
    }
}