using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace n01237816_HTTP5101_FinalProject
{
    public class Webpages
    {
        private string Page_Title;
        private string Page_Body;

        public string GetTitle()
        {
            return Page_Title;
        }
        public string GetBody()
        {
            return Page_Body;
        }

        public void SetTitle(string value)
        {
            Page_Title = value;
        }
        public void SetBody(string value)
        {
            Page_Body = value;
        }
    }
}