using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_Pages
{
    public partial class MasterSample : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int hours = DateTime.Now.Hour;
            if( hours < 11)
            {
                Greatinglbl.Text = "Good Morning!";
            }
            else if( hours > 12 && hours < 5)
            {
                Greatinglbl.Text = "Good Afternoon!";
            }
            else
            {
                Greatinglbl.Text = "Good Evening";
            }
        }
    }
}