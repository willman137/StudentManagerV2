using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManager.Classes
{
    public class RequestDirector
    {
        public static Boolean CreateProgram(String ProgramCode, String Description)
        {
            return Programs.AddProgram(ProgramCode, Description);
        }

        public static bool EnrollStudent(Student AccecptedStudent, String ProgramCode)
        {
            return Students.AddStudent(AccecptedStudent, ProgramCode);
        }

        public static Student FindStudent(String StudentID)
        {
            return Students.GetStudent(StudentID);
        }

        public static bool ModifyStudent(Student EnrolledStudent)
        {
            return Students.UpdateStudent(EnrolledStudent);
        }

        public static bool RemoveStudent(Student EnrolledStudent)
        {
            return Students.DeleteStudent(EnrolledStudent);
        }

        public static Program FindProgram(String ProgramCode)
        {
            Program p = Programs.GetProgram(ProgramCode);
            return p;
        }

        public static Program FindProgramV2(String ProgramCode)
        {
            Program p = Programs.GetProgramV2(ProgramCode);
            return p;
        }

        //bottom two lines of code are added in by myself. Further on, I will replace all calls properly./
    }
}