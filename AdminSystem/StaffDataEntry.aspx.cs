using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }




    protected void btnOk_Click1(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff.firstName = txtfirstName.Text;
        AStaff.StaffId = int.Parse(txtStaffId.Text);
        AStaff.surname = txtsurname.Text;
        AStaff.dateOfBirth = DateTime.Parse(txtdateOfBirth.Text);
        AStaff.password = txtpassword.Text;
        if (chkmanagerOrStaff.Checked)
        {
            AStaff.managerOrStaff = true;
        } else
        {
            AStaff.managerOrStaff = false;
        }

        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }
}