using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01237816_HTTP5101_FinalProject
{
    public partial class UpdatePost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                PagesConfig controller = new PagesConfig();
                ShowPostInfo(controller);
            }
        }

        protected void Update_Post(object sender, EventArgs e)
        {

            PagesConfig controller = new PagesConfig();

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                Webpages new_page = new Webpages();
                //call post data from form
                new_page.SetTitle(post_title.Text);
                new_page.SetBody(post_body.Text);

                //add the post to the database
                try
                {
                    controller.UpdatePage(Int32.Parse(pageid), new_page);
                    Response.Redirect("ReadPage.aspx?pageid=" + pageid);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                post.InnerHtml = "Sorry! There was an issue updating this post.";
            }

        }

        protected void ShowPostInfo(PagesConfig controller)
        {

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {

                Webpages new_page = controller.FindPage(Int32.Parse(pageid));
                posttitle.InnerHtml = new_page.GetTitle();
                post_title.Text = new_page.GetTitle();
                post_body.Text = new_page.GetBody();

                if (!valid)
                {
                    post.InnerHtml = "Sorry! There was an error finding that post.";
                }
            }
        }
    }
}