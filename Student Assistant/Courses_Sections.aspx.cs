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
    public partial class Courses_Sections : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddCourseWithSection(object sender, EventArgs e)
        {

            //Response.Redirect("~/About");

            SqlCommand com = new SqlCommand("Crs_Sec", myConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CName", Coursename.Text);
            com.Parameters.AddWithValue("@Sec", section.Text);
            com.Parameters.AddWithValue("@Dep", department.SelectedValue);
           
            myConnection.Open();
            int i = com.ExecuteNonQuery();
            myConnection.Close();
            if (i >= 1)
            {
                eror.InnerText = "Course added successfully!";

            }
            else
            {
                eror.InnerText = "Course is not added successfully!";

            }
        }

        protected void ViewCourses(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    // Executes only the first time the page is processed. After
            //    // that, the list is already in the drop-down list and is
            //    // preserved in view state.
            //    System.Data.SqlClient.SqlDataReader dreader;
            //    myConnection.Open();
            //    dreader =  cmdCategoriesAll.ExecuteReader();
            //    bool firstrow = true;
            //    while (dreader.Read())
            //    {
            //        ddlCategoryID.Items.Add(new ListItem(dreader[0].ToString()));
            //        if (firstrow)
            //        {
            //            txtCategoryName.Text = dreader[1].ToString();
            //            txtCategoryDescription.Text = dreader[2].ToString();
            //            firstrow = false;
            //        }
            //    }
            //    dreader.Close();
            //    sqlConnection1.Close();
            //}

            //Response.Redirect("~/About");

            SqlCommand com = new SqlCommand("Crs_Sec", myConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CName", Coursename.Text);
            com.Parameters.AddWithValue("@Sec", section.Text);
            com.Parameters.AddWithValue("@Dep", department.SelectedValue);

            myConnection.Open();
            int i = com.ExecuteNonQuery();
            myConnection.Close();
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