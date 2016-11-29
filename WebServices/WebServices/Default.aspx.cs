using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServices
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.CoreService proxy = new localhost.CoreService();

            DataSet table = proxy.GetCustomersByCountry("USA");
            grid.DataSource = table;
            grid.DataBind();
            int g = 42;
            binary.Text = g+" To Binary: "+proxy.DecimalToBinary(g);

            int t = 01110101;
            listen.Text = t + " To Decimal: " + proxy.BinaryToDecimal(t);

            int h = 43;
            closely.Text = "Is " + h + " a prime #? " + (proxy.IsItPrime(h) ? "Yes": "No");
                }
    }
}