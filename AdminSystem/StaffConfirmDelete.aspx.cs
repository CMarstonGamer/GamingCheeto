using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 staffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection staffBook = new clsStaffCollection();
        staffBook.ThisStaff.Find(staffId);
        staffBook.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}