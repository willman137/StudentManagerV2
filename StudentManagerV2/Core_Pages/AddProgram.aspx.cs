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
    public partial class AddProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                Program p = new Program();
                p.ProgramCode = Program_Code.Text;
                p.Description = Description.Text;
                RequestDirector.CreateProgram(Program_Code.Text,Description.Text);
                Response.Write("<script>alert(\"Successfully added Program\")</script>");
            }
            catch (SqlException ex)
            {
                Response.Write(ex.StackTrace);
            }
        }
    }
}