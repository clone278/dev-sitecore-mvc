using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glass.Mapper.Sc;
using dev.sitecore.mvc.Models.Landing;

namespace dev.sitecore.mvc.Layouts
{
    public partial class Hello : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new SitecoreContext();
            lit1.Text = context.Database.Name;
        }
    }
}