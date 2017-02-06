using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Env = ConfigurationManager.AppSettings["Environment"].ToString();
        lblEnv.Text = Env.Substring(0,3);
        Label1.Text = Env;
    }
}