using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace StudentManager.Core_Pages
{
    public partial class XML_Reader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //attempting a dynamic read
            XmlReaderSettings settings;
            settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader reader;
            reader = XmlReader.Create(Server.MapPath(@"Files\test.xml"), settings);

            TableHeaderRow HeaderRow;
            HeaderRow = new TableHeaderRow();

            //jumping strainght to reading the actual data
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: 
                        if (reader.HasAttributes) {
                            PopulateTable("Element", reader);
                            while ( reader.MoveToNextAttribute() ) { 
                                PopulateTable("Attribute", reader);
                            }
                        }
                        else{
                            PopulateTable("Start Element", reader);
                        }
                        break;
                    case XmlNodeType.Text:
                        PopulateTable("Text",reader);
                        break;
                    case XmlNodeType.EndElement:
                        PopulateTable("End Element",reader);
                        break;
                }
            }


        }

        private void PopulateTable(string RowText, XmlReader reader) {
            TableRow row;
            row = new TableRow(); 

            TableCell cell = new TableCell();
            cell.Text = RowText;
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = reader.Depth.ToString();
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = reader.Name;
            row.Cells.Add(cell);

            cell = new TableCell();
            cell.Text = reader.Value;
            row.Cells.Add(cell);

            Results.Rows.Add(row);
        }
    }
}