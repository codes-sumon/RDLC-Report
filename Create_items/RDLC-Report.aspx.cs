using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Create_items
{
    public partial class RDLC_Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(DBManager.OraConnString());
        protected void btnLoadReport_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from createItems", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            RDLCReportView.LocalReport.DataSources.Clear();

            ReportDataSource source = new ReportDataSource("ItemDataSet", dt);
            RDLCReportView.LocalReport.ReportPath = Server.MapPath("ItemReport.rdlc");
            RDLCReportView.LocalReport.SetParameters(new ReportParameter("ReportName", "Item Report"));
            RDLCReportView.LocalReport.DataSources.Add(source);
            RDLCReportView.LocalReport.Refresh();
        }
    }
}