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
    public partial class Registeration : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click1(object sender, EventArgs e)
        {

            //Response.Redirect("~/About");

            SqlCommand com = new SqlCommand("InsertData", myConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FName", firstname.Text);
            com.Parameters.AddWithValue("@Lname", lastname.Text);
            com.Parameters.AddWithValue("@Gender", rblist1.SelectedValue);
            com.Parameters.AddWithValue("@email", emailBox.Text);
            com.Parameters.AddWithValue("@pass", PasswordBox.Text);
            myConnection.Open();
            int i = com.ExecuteNonQuery();
            myConnection.Close();
            if (i >= 1)
            {
                eror.InnerText = "User added successfully!";

            }
            else
            {
                eror.InnerText = "User is not added successfully!";

            }

            /*string query = "Insert into User(FirstName,LastName,Gender,Email,Password) Values (@fn,@ln,@gen,@em,@pas)";
            SqlCommand insertCommand = new SqlCommand(query, myConnection);
            insertCommand.Parameters.AddWithValue("@fn", firstname.Text);
            insertCommand.Parameters.AddWithValue("@ln", lastname.Text);
            insertCommand.Parameters.AddWithValue("@gen", rblist1.SelectedValue);
            insertCommand.Parameters.AddWithValue("@em", emailBox.Text);
            insertCommand.Parameters.AddWithValue("@pas", PasswordBox.Text);

            myConnection.Open();
            insertCommand.ExecuteNonQuery();
            myConnection.Close();
            eror.InnerText = "User added successfully!";

            // SqlTransaction sqt = myConnection.BeginTransaction();
            //insertCommand.Connection = myConnection;
            //insertCommand.Transaction = sqt;


            /*try
            {
                myConnection.Open();
                insertCommand.ExecuteNonQuery();
                sqt.Commit();
            }
            catch (Exception es)
            {
                //eror.Visible = true;
                //Label myLabel = this.FindControl("eror") as Label;
                eror.InnerText = es.Message.ToString();
                sqt.Rollback();
            }
            finally
            {
                myConnection.Close();
                myConnection.Dispose();
            }*/







        }
    }
}