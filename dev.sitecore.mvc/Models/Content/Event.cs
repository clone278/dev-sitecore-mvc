﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Globalization;

namespace dev.sitecore.mvc.Models.Content
{
    public class Event
    {
        public virtual Guid Id { get; set; }

        public virtual Language Language { get; set; }

        public virtual string Title { get; set; }

        public virtual string MainBody { get; set; }

        public virtual string Abstract { get; set; }

        public virtual string Location { get; set; }

        public virtual DateTime Start { get; set; }

        public virtual DateTime End { get; set; }

        public virtual string Url { get; set; }
    }
}