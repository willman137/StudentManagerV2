using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentManager.Classes
{
    public class Programs
    {
        private static SqlConnection conn = null;
        private static SqlCommand cmd = null;
        private static SqlDataReader reader = null;
        public static bool AddProgram(string programCode, string description)
        {
            Program ret = new Program();

            SqlConnection theConnection = new SqlConnection();
            theConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentContextManager"].ConnectionString;

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = theConnection;
            cmd.CommandText = "AddProgram";

            //@CustomerID nchar(5)
            SqlParameter ProgramCode = new SqlParameter("@ProgramCode", programCode.Trim()),
                         Description = new SqlParameter("@Description", description.Trim());
            cmd.Parameters.Add(ProgramCode);
            cmd.Parameters.Add(Description);
            theConnection.Open();

            cmd.ExecuteNonQuery();

            theConnection.Close();

            return true;

        }

        public static Program GetProgram(string programCode)
        {
            Program ret = null;

                SqlConnection theConnection = new SqlConnection();
                theConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentContextManager"].ConnectionString;

                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = theConnection;
                cmd.CommandText = "Getprogram";

                //@CustomerID nchar(5)
                //SqlParameter ProgramCode = new SqlParameter("ProgramCode ", programCode);
                cmd.Parameters.Add(new SqlParameter("@ProgramCode", programCode));
                
                theConnection.Open();

                SqlDataReader theDataReader;
                theDataReader = cmd.ExecuteReader();

                while (theDataReader.Read())
                {
                    ret = new Program();
                    ret.ProgramCode = (String) theDataReader["ProgramCode"];
                    ret.Description = (String) theDataReader["Description"];
                }

                theConnection.Close();
                
                return ret;

        }

        //framework for entityframework is here
        public static bool AddProgramV2(String programcode, String description)
        {
            Program p = new Classes.Program();
            p.ProgramCode = programcode.Trim();
            p.Description = description.Trim();
            return AddProgramV2(p);
        }

        public static bool AddProgramV2(Program program)
        {
            using (var context = new StudentManagerContext())
            {
                if (program != null)
                {
                    context.Programs.Add(program);
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }

        public static Program GetProgramV2(String programcode)
        {
            using (var context = new StudentManagerContext())
            {
                //context.programs ins causing an error, LazyInternalConnection, connection.has model(). There is no model created so that's more that likly why.
                foreach (Program p in context.Programs)
                {
                    if (p.ProgramCode == programcode)
                        return p;
                }
                return null;
            }
        }
    }
} 