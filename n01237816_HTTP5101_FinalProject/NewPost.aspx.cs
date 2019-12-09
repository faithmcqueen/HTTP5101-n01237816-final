using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01237816_HTTP5101_FinalProject
{
    public partial class NewPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 

        }

        protected void AddPost (object sender, EventArgs e)
        {
            //Connect to PagesConfig class
            PagesConfig db = new PagesConfig();

            //Create a new post
            Webpages new_post = new Webpages();
            new_post.SetTitle(page_title.Text);
            new_post.SetBody(page_body.Text);

            db.AddPost(new_post);

            Response.Redirect("ListPosts.aspx");
        }
    }
}