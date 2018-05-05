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
    public partial class Events : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddNewEvent(object sender, EventArgs e)
        {

            //Response.Redirect("~/About");

            SqlCommand com = new SqlCommand("AddEvents", myConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Title", EventTitle.Text);
            com.Parameters.AddWithValue("@Course", crs.SelectedValue);
            com.Parameters.AddWithValue("@Section", sec.SelectedValue);
            com.Parameters.AddWithValue("@Desc", Desc.Text);
            com.Parameters.AddWithValue("@Venue", ven.Text);

            myConnection.Open();
            int i = com.ExecuteNonQuery();
            myConnection.Close();
            if (i >= 1)
            {
                eror.InnerText = "Event added successfully!";

            }
            else
            {
                eror.InnerText = "Event is not added successfully!";

            }
        }
        protected void ViewAllEvents(object sender, EventArgs e)
        {

            //Response.Redirect("~/About");

            //SqlCommand com = new SqlCommand("AddEvents", myConnection);
            //com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@Title", EventTitle.Text);
            //com.Parameters.AddWithValue("@Course", crs.SelectedValue);
            //com.Parameters.AddWithValue("@Section", sec.SelectedValue);
            //com.Parameters.AddWithValue("@Desc", Desc.Text);
            //com.Parameters.AddWithValue("@Venue", ven.Text);

            //myConnection.Open();
            //int i = com.ExecuteNonQuery();
            //myConnection.Close();
            //if (i >= 1)
            //{
            //    eror.InnerText = "Event added successfully!";

            //}
            //else
            //{
            //    eror.InnerText = "Event is not added successfully!";

            //}
        }
    }
}