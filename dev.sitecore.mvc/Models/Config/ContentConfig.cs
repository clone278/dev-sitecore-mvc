using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Fluent;
using dev.sitecore.mvc.Models.Content;

namespace dev.sitecore.mvc.Models.Config
{
    public class ContentConfig
    {
        public static SitecoreFluentConfigurationLoader Load()
        {
            var loader = new SitecoreFluentConfigurationLoader();

            var eventConfig = loader.Add<Event>().AutoMap();
            eventConfig.Field(x => x.Title);
            eventConfig.Id(x => x.Id);
            eventConfig.Info(x => x.Language).InfoType(SitecoreInfoType.Language);

            return loader;
        }
    }
}