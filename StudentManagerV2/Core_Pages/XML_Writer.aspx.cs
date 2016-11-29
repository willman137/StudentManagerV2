using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace StudentManager.Core_Pages
{
    public partial class XML_Writer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlWriterSettings settings;
            settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "  ";

            //initializing writer
            XmlWriter writer;
            writer = XmlWriter.Create(Server.MapPath(@"files\logs\test.xml"),settings);

            //writing xml file...
            writer.WriteStartDocument();
                //good point to implement a foreach 
                writer.WriteStartElement("");
            writer.WriteEndDocument();
            writer.Flush();
        }
    }
}