using StudentManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManager
{
    public partial class EnrollStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentID = Student_ID.Text;
            s.FirstName = FirstName.Text;
            s.LastName = LastName.Text;
            s.Email = Email.Text;
            //should add a check to see if program exists. Either here of the called procedure
            
            RequestDirector.EnrollStudent(s, Program_Code.Text);
            Response.Write("<script> alert(\"Student Enrolled Successfully\")</script>");
        }
    }
}