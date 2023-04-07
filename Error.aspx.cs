using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRMS
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] != null)
            {
                if (Session["role"].ToString() == "5")
                    Session["DashBoardlink"] = "../Home/ManagerDashBoard.aspx";
                else if (Session["role"].ToString() == "6")
                    Session["DashBoardlink"] = "../Home/ManagementDashboard.aspx";
                else if (Session["role"].ToString() == "2")
                    Session["DashBoardlink"] = "../Home/UserDashboard.aspx";
                else
                    Session["DashBoardlink"] = "../Home/Dashboard.aspx";
            }
        }
    }
}