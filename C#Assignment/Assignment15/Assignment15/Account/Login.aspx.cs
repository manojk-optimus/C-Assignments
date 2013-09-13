using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment15.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            Session["UserName"] = "0";
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
           
            Response.Write("Session Variable is stored......");
            Session["Username"] = "1";
            Response.Redirect("TechNews.aspx");
        }
        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
