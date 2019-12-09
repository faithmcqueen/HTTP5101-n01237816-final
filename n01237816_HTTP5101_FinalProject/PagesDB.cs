using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace n01237816_HTTP5101_FinalProject
{
    public class PagesDB
    {
        //Create connection string
        private static string User { get { return "root@localhost"; } }
        private static string Database { get { return "webpages"; } }
        //No password for database user
        private static string Server { get { return "127.0.0.1"; } }
        private static string Port { get { return "3306"; } }

        // create a connection string 

        protected static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port;
            }
        }

        public List<Dictionary<String, String>> List_Pages(string query)
        {
            MySqlConnection Connect = new MySqlConnection (ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            //Write try and catch for debugging

            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();

                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));
                    }

                    ResultSet.Add(Row);
                }

                resultset.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Page method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;

        }

    }


}