using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Write Cookie
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = "Mike";
            cookie["Email"] = "Email@email.com";

            //persistent cookie
            cookie.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Add(cookie);

            Response.Redirect("webform2.aspx");

            //Read Cookie
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if(cookie != null)
            {
                string Name = cookie["Name"];
                string Email = cookie["Email"];
            }
        }

    }
}