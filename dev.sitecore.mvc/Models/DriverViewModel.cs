﻿using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dev.sitecore.mvc.Models
{
    public class DriverViewModel
    {
        public Driver Driver { get; set; }
        public string Background { get; set; }
        public Item ContextItem { get; set; }
    }
}