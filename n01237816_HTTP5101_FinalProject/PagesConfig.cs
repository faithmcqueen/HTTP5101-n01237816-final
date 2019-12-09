using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace n01237816_HTTP5101_FinalProject
{
    public class PagesConfig : PagesDB
    {
        public void AddPost(Webpages new_post)
        {
            string query = "insert into pages (page_title, page_body) values ('{0}','{1}')";
            query = String.Format(query, new_post.GetTitle(), new_post.GetBody());

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the add post method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void UpdatePage (int page_id, Webpages new_page)
        {
            string query = "update pages set page_title='{0}', page_body='{1}'";
            query = String.Format(query, new_page.GetTitle(), new_page.GetBody(), page_id);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the Update Page method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void DeletePage(int page_id)
        {
            string deletepost = "delete from pages where page_id = '{0}'";
            deletepost = String.Format(deletepost, page_id);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd_deletepost = new MySqlCommand(deletepost, Connect);

            try
            {
                Connect.Open();
                cmd_deletepost.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_deletepost);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the delete post method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public Webpages FindPage(int id)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Webpages show_page = new Webpages();
            try
            {
                string query = "select * from pages where page_id = " + id;
                Debug.WriteLine("Connection Initialized...");
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();

                List<Webpages> post = new List<Webpages>();

                while (resultset.Read())
                {
                    Webpages currentpage = new Webpages();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);

                        switch (key)
                        {
                            case "page_title":
                                currentpage.SetTitle(value);
                                break;
                            case "page_body":
                                currentpage.SetBody(value);
                                break;

                        }
                    }

                    post.Add(currentpage);
                }

                show_page = post[0];
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the find page method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return show_page;

        }

    }
}