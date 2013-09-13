using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment_9;

namespace CustomException
{
    
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IsCarDeadException x = new IsCarDeadException("heello");
            Console.WriteLine(x.Data);
        }
    }
    
}
