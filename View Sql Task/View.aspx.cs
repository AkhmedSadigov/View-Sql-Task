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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_click(object sender, EventArgs e)
        {
            SqlConnection SQLConn = new SqlConnection("Data Source=LAPTOP-D0D6I3G9\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SQLConn.Open();
            SqlCommand cmd = new SqlCommand("Select * from View_C#task where CategoryName='" + txtbox1.Text + "'", SQLConn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                GridView1.DataSource = tb;
                GridView1.DataBind();
                lbl2.Text = "";
            }
            else
            {
                lbl2.Text = "Not Found";
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }

        protected void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}