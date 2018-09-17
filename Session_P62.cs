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
            
            //Write Session
            
            Session["Name"] = "Mike";
            Session["Email"] = "Email@email.com";

            Response.Redirect("~/webform2.aspx");

            //Read Cookie
            if (Session["Name"] != null)
            {
                string Name = Session["Name"].ToString();
            }
            if (Session["Email"] != null)
            {
                string Email = Session["Email"].ToString();
            }
        }

    }
}

//<sessionState mode = "InProc" timeout ="20" cookieless="true" customProvider="DefaultSessionProvider">