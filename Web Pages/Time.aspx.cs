using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_Pages.Web_Pages
{
    public partial class Time : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Curtimelbl.Text = "";
        }

        protected void Timebtn_Click(object sender, EventArgs e)
        {
            Curtimelbl.Text = DateTime.Now.ToString();
        }
    }
}