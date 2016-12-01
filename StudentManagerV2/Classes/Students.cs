using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace StudentManager.Classes
{
        public class Students
        {
            private static SqlCommand cmd = null;
            private static SqlConnection conn = null;
            private static SqlDataReader rdr = null;

        public static bool AddStudent(Student accecptedStudent, string programCode)
        {
            SqlConnection theConnection = new SqlConnection();
            theConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentContextManager"].ConnectionString;

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = theConnection;
            cmd.CommandText = "AddStudent";

            //@CustomerID nchar(5)

            cmd.Parameters.Add(new SqlParameter("@StudentID", accecptedStudent.StudentID));
            cmd.Parameters.Add(new SqlParameter("@FirstName", accecptedStudent.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", accecptedStudent.LastName));
            cmd.Parameters.Add(new SqlParameter("@Email", accecptedStudent.Email));
            //need to remove this field in the procedure
            cmd.Parameters.Add(new SqlParameter("@ProgramCode", programCode));
            theConnection.Open();

            cmd.ExecuteNonQuery();

            theConnection.Close();

            return true;
        }

        public static Student GetStudent(string studentID)
        {
            Student ret = null; 
            SqlConnection theConnection = new SqlConnection();
            theConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentContextManager"].ConnectionString;

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = theConnection;
            cmd.CommandText = "GetStudent";

            //@CustomerID nchar(5)

            cmd.Parameters.Add(new SqlParameter("@StudentID", studentID));
            theConnection.Open();
            SqlDataReader theDataReader;
            theDataReader = cmd.ExecuteReader();

           if(theDataReader.Read())
            {
                ret = new Student();
                ret.StudentID = (String)theDataReader["StudentID"];
                ret.ProgramCode = (String)theDataReader["ProgramCode"];
                ret.Email = (String)theDataReader["Email"];
                ret.FirstName = (String)theDataReader["FirstName"];
                ret.LastName = (String)theDataReader["LastName"];
            }

            theConnection.Close();

            return ret;

        }

        public static bool UpdateStudent(Student enrolledStudent)
        {
            SqlConnection theConnection = new SqlConnection();
            theConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentContextManager"].ConnectionString;

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = theConnection;
            cmd.CommandText = "UpdateStudent";

            //@CustomerID nchar(5)

            cmd.Parameters.Add(new SqlParameter("@StudentID", enrolledStudent.StudentID));
            cmd.Parameters.Add(new SqlParameter("@FirstName",enrolledStudent.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName",enrolledStudent.LastName));
            cmd.Parameters.Add(new SqlParameter("@Email", enrolledStudent.Email));
            //cmd.Parameters.Add(new SqlParameter("@ProgramCode", enrolledStudent.ProgramCode));

            //need to remove this field in the procedure

            theConnection.Open();

            cmd.ExecuteNonQuery();

            theConnection.Close();

            return true;
        }

        public static bool DeleteStudent(Student enrolledStudent)
        {
            SqlConnection theConnection = new SqlConnection();
            theConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentContextManager"].ConnectionString;

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = theConnection;
            cmd.CommandText = "DeleteStudent";

            //@CustomerID nchar(5)

            cmd.Parameters.Add(new SqlParameter("@StudentID", enrolledStudent.StudentID));

            theConnection.Open();

            cmd.ExecuteNonQuery();

            theConnection.Close();

            return true;
        }

        public static bool DeleteStudents(string programCode)
        {
            SqlConnection theConnection = new SqlConnection();
            theConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentContextManager"].ConnectionString;

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = theConnection;
            cmd.CommandText = "RemoveStudents";

            //@CustomerID nchar(5)

            cmd.Parameters.Add(new SqlParameter("@ProgramCode", programCode));

            theConnection.Open();

            cmd.ExecuteNonQuery();

            theConnection.Close();

            return true;
        }
    }
}