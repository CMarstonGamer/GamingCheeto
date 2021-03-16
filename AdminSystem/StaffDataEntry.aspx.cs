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
        AStaff.staffId = int.Parse(txtStaffId.Text);
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 staffId;
        Boolean Found = false;
        staffId = Convert.ToInt32(txtStaffId.Text);
        Found = AStaff.Find(staffId);
        if (Found == true)
        {
            txtfirstName.Text = AStaff.firstName;
            txtsurname.Text = AStaff.surname;
            txtdateOfBirth.Text = AStaff.dateOfBirth.ToString();
            txtpassword.Text = AStaff.password;

        }
        else
        {
            lblError.Text = "Data entry not found";
        }
    }
}