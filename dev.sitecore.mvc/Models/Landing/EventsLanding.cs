using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using dev.sitecore.mvc.Models.Content;
using dev.sitecore.mvc.Models.Misc;

namespace dev.sitecore.mvc.Models.Landing
{
    [SitecoreType(AutoMap = true)]
    public class EventsLanding : ContentBase
    {
        [SitecoreQuery("./*[@@templatename='Event']", IsRelative = true)]
        public virtual IEnumerable<Event> Events { get; set; }
    }
}