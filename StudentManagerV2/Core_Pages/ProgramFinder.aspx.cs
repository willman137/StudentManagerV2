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
    public partial class ProgramFinder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Found_Program"] != null)
            {
                //Program p = (Program)Session["Found_Program"];
                //Response.Write("<script>alert(\"Successfully Found Program: "+ p.ProgramCode+"\")</script>");
                //reseting the session variable
                Session["Found_Program"] = null;

            //    Table table = new Table();
            //    TableHeaderRow header = new TableHeaderRow();
            //    TableHeaderCell headercell = new TableHeaderCell(), headercell2 = new TableHeaderCell();
            //    headercell.Text = "Program Code";
            //    headercell2.Text = "Description";

            //    header.Cells.Add(headercell);
            //    header.Cells.Add(headercell2);

            //    table.Rows.Add(header);

            //    for (int i = 0; i < 1; i++)
            //    {
            //        TableRow row = new TableRow();
                    
            //            TableCell cell1 = new TableCell(), cell2 = new TableCell();
            //            cell1.Text = p.ProgramCode;
            //            cell2.Text = p.Description;
            //            row.Cells.Add(cell1);
            //        row.Cells.Add(cell2);

            //        table.Rows.Add(row);
            //    }
            }

        }

        protected void Find_Click(object sender, EventArgs e)
        {
            try
            {
                Program prog = RequestDirector.FindProgram(Program_Code.Text);
                if (prog != null)
                {
                    Session.Add("Found_Program", prog);
                    Response.Write("<script>alert(\"Successfully Found Program: " + prog.ProgramCode + "\")</script>");
                }
                else
                    Response.Write("Program not found");
            }
            catch (SqlException err)
            {
                Response.Write(err.Message);
            }
            catch(Exception ex)
            {
                Response.Write(ex.StackTrace);
            }
        }
    }
}