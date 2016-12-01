using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace StudentManagerV2
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {
        [WebMethod(Description = "First Web Service")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "Gets a country by its code")]
        public DataSet GetCustomersByCountry(string countryCode)
        {
            DataSet northwind = new DataSet();
            northwind.DataSetName = "Northwind";

            DataTable customers = new DataTable();
            customers.TableName = "Customers";

            northwind.Tables.Add(customers);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthwindContextManager"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetCustomersByCountry";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@CountryCode", countryCode));
            cmd.Connection = conn;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            customers.Load(reader);
            conn.Close();

            return northwind;
        }

        [WebMethod]
        public int BinaryToDecimal(int n)
        {
            int ret = Convert.ToInt32("" + n, 2);
            return ret;
        }

        [WebMethod]
        public int DecimalToBinary(int n)
        {
            int ret = Int32.Parse(Convert.ToString(n, 2));
            return ret;
        }

        [WebMethod]
        public bool IsItPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

