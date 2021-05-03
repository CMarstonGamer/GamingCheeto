using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 staffId2;
    
    protected void Page_Load(object sender, EventArgs e)
    {
       staffId2 = Convert.ToInt32(Session["staffId"]);
        if (IsPostBack == false)
        {
            if (staffId2 != -1)
            {
                DisplayStaff();
            }
        }

    }

    void DisplayStaff()
    {
        clsStaffCollection staffBook = new clsStaffCollection();
        staffBook.ThisStaff.Find(staffId2);
        txtStaffId.Text = staffBook.ThisStaff.staffId.ToString();
        txtfirstName.Text = staffBook.ThisStaff.firstName.ToString();
        txtsurname.Text = staffBook.ThisStaff.surname.ToString();
        chkmanagerOrStaff.Checked = staffBook.ThisStaff.managerOrStaff;
        txtdateOfBirth.Text = staffBook.ThisStaff.dateOfBirth.ToString();
        txtpassword.Text = staffBook.ThisStaff.password.ToString();
    }



    protected void btnOk_Click1(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        string firstName = txtfirstName.Text;
        string staffId = txtStaffId.Text;
        string surname = txtsurname.Text;
        string dateOfBirth = txtdateOfBirth.Text;
        string password = txtpassword.Text;
        string Error = "";

        if (chkmanagerOrStaff.Checked)
        {
            AStaff.managerOrStaff = true;
        } else
        {
            AStaff.managerOrStaff = false;
        }
        Error = AStaff.Valid(firstName, surname, dateOfBirth, password);
        if (Error == "")
        {
            AStaff.firstName = firstName;
            AStaff.surname = surname;
            AStaff.dateOfBirth = Convert.ToDateTime(dateOfBirth);
            AStaff.password = password;

            clsStaffCollection StaffList = new clsStaffCollection();
            if (staffId2 == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(staffId2);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }
            
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}