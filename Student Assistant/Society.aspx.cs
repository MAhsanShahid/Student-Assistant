using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Student_Assistant
{
    
    public partial class Society : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddSociety(object sender, EventArgs e)
        {

            //Response.Redirect("~/About");

            SqlCommand com = new SqlCommand("AddSociety", myConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Sname", Societyname.Text);
            com.Parameters.AddWithValue("@Desc", Desc.Text);
            com.Parameters.AddWithValue("@post", post.Text);

            myConnection.Open();
            int i = com.ExecuteNonQuery();
            myConnection.Close();
            if (i >= 1)
            {
                eror.InnerText = "Society added successfully!";

            }
            else
            {
                eror.InnerText = "Society is not added successfully!";

            }
        }

        protected void ViewSociety(object sender, EventArgs e)
        {

            //Response.Redirect("~/About");

            //SqlCommand com = new SqlCommand("Crs_Sec", myConnection);
            //com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@CName", Coursename.Text);
            //com.Parameters.AddWithValue("@Sec", section.Text);
            //com.Parameters.AddWithValue("@Dep", department.SelectedValue);

            //myConnection.Open();
            //int i = com.ExecuteNonQuery();
            //myConnection.Close();
            //if (i >= 1)
            //{
            //    eror.InnerText = "Course added successfully!";

            //}
            //else
            //{
            //    eror.InnerText = "Course is not added successfully!";

            //}
        }
    }
}