using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace n01237816_HTTP5101_FinalProject
{
    public partial class ListPosts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            posts_result.InnerHtml = "";

            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = post_search.Text;
            }

            string query = "select * from STUDENTS";

            if (searchkey != "")
            {
                query += " WHERE page_title like '%" + searchkey + "%' ";
                query += " or page_body like '%" + searchkey + "%' ";
            }

            var db = new PagesDB();
            List<Dictionary<String, String>> rs = db.List_Pages(query);
            foreach(Dictionary<String,String> row in rs)
            {
                posts_result.InnerHtml += "<div class=\"listitem\">";

                string postid = row["page_id"];
                string posttitle = row["page_title"];

                posts_result.InnerHtml += "<div><a href=\"ReadPage.aspx?pageid=" + postid + "\">" + posttitle + "</a></div>";

                posts_result.InnerHtml += "</div>";

            }

        }
    }
}