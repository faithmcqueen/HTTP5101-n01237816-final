using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls.Resolvers;

namespace n01237816_HTTP5101_FinalProject
{
    public partial class ViewSwitcher : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PagesDB db = new PagesDB();
            ListPages(db);
        }

        protected void ListPages(PagesDB db)
        {
            string query = "select * from pages";
            List<Dictionary<String, String>> rs = db.List_Pages(query);

            foreach (Dictionary<String, String> row in rs)
            {
                all_posts.InnerHtml += row["page_title"];

            }
        }
    }
}