using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01237816_HTTP5101_FinalProject
{
    public partial class ReadPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            PagesConfig controller = new PagesConfig();
            //get post information from DB
            ShowPostInfo(controller);

        }

        protected void ShowPostInfo (PagesConfig controller)
        {
            bool valid = true;
            string pageid = Request.QueryString["page_id"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {
                Webpages page_content = controller.FindPage(Int32.Parse(pageid));

                posttitle.InnerHtml = page_content.GetTitle();
                postbody.InnerHtml = page_content.GetBody();

            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                post.InnerHtml = "There was an error finding that post.";
            }
        }

        protected void Delete_Post (object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["page_id"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            PagesConfig controller = new PagesConfig();

            //deleting the student from the system
            if (valid)
            {
                controller.DeletePage(Int32.Parse(pageid));
                Response.Redirect("ListPosts.aspx");
            }
        }
    }
}