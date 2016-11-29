using StudentManager.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManager.MasterPages
{
    public partial class ModifyStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ModifySubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = RequestDirector.FindStudent(Student_ID.Text);
                if (s != null)
                {
                    s.FirstName = FirstName.Text;
                    s.LastName = LastName.Text;
                    s.Email = Email.Text;
                    RequestDirector.ModifyStudent(s);
                    Response.Write("<script>alert(\"Student Modified Successfully\")</script>");
                }
                else
                {
                    Response.Write("<script>alert(\"Did not modify student\")</script>");
                }
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert(\"Did not modify student, There was a backed error\")</script>");
            }
        }
        protected void ModifySubmit_Click2(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Student s = RequestDirector.FindStudent(Student_ID.Text);
                if (s != null)
                {
                    FirstName.Text = s.FirstName;
                    LastName.Text = s.LastName;
                    Email.Text = s.Email;
                    Response.Write("<script>alert(\"Successfully Found Student\")</script>");
                }
                else
                {
                    Response.Write("<script>alert(\"Did not find Student\")</script>");
                }
            }
            else
            {
                Student s = RequestDirector.FindStudent(Student_ID.Text);
                if (s != null)
                {
                    s.FirstName = FirstName.Text;
                    s.LastName = LastName.Text;
                    s.Email = Email.Text;
                    RequestDirector.ModifyStudent(s);
                    Response.Write("<script>alert(\"Student Modified Successfully\")</script>");
                }
                else
                {
                    Response.Write("<script>alert(\"Did not modify student\")</script>");
                }
            }
        }
    }
}