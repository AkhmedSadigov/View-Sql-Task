using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace View_Sql_Task
{
    public partial class View : System.Web.UI.Page
    {
        bool PrmtrsChange = false;

        SqlConnection SQLConn = new SqlConnection("Data Source=LAPTOP-D0D6I3G9\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_click(object sender, EventArgs e)
        {
            if (PrmtrsChange) Session["data"] = null;
            PrmtrsChange = false;
            BindMethod();
        }

        private void BindMethod()
        {
            if (Session["data"] == null)
            {
                SQLConn.Open();
                SqlCommand cmd = new SqlCommand("Select * from View_C#task where CategoryName='" + txtbox1.Text + "'", SQLConn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                adapter.Fill(tb);

                if (tb.Rows.Count > 0)
                {
                    Session["data"] = tb;
                }
                else
                {
                    lbl2.Text = "Not Found";
                    Session["data"] = null;
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    SQLConn.Close();
                    return;
                }
                SQLConn.Close();
            }
            GridView1.DataSource = Session["data"];
            GridView1.DataBind();
            lbl2.Text = "";
        }

        protected void txtbox1_TextChanged(object sender, EventArgs e)
        {
            PrmtrsChange = true;
        }

        protected void datagrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            btn1_click(sender, e);
        }
    }
}