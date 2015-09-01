using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dev.sitecore.mvc.Models
{
    public class Circuit : RenderingModel
    {
        public HtmlString Name
        {
            get
            {
                return new HtmlString(FieldRenderer.Render(this.Item, "Name"));
            }
        }

        public HtmlString Text
        {
            get
            {
                return new HtmlString(FieldRenderer.Render(this.Item, "Text"));
            }
        }


    }
}