using StudentManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManager
{
    public partial class RemoveStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            Student s = RequestDirector.FindStudent(Student_ID.Text);
            RequestDirector.RemoveStudent(s);
            Response.Write("Student Removed");
        }
    }
}