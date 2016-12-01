using StudentManager.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManager
{
    public partial class FindStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Find_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = RequestDirector.FindStudent(Student_ID.Text);
                if (s != null)
                {
                    Response.Write("<script>alert(\"" + s.ProgramCode + " was found in the system\")");

                }
                else {
                    Response.Write("<script>alert(\"Student was not found in the system\")");
                }
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert(\"Student was not found in the system\")");
            }

        }
    }
}