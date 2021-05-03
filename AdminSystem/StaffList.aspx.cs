using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }

    }


    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "firstName";
        lstStaffList.DataTextField = "surname";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["staffId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 staffId;
        if(lstStaffList.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["staffId"] = staffId;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            Error.Text = "Please slect a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 staffId;
        if(lstStaffList.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = staffId;
            Response.Redirect("StaffConfirmDelete.aspx");

        }
        else
        {
            Error.Text = "Please select a record to delete from the list,, SOS";
        }
    }
}