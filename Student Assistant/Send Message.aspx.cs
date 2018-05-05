using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace Student_Assistant
{
    public partial class Send_Message : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SendMessage(object sender, EventArgs e)
        {
            MailMessage mailObj = new MailMessage(
           reciever.Text, senderr.Text, sub.Text, msg.Text);
            SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "myIDPassword");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();

            //Setting From , To and CC
            mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
            mail.To.Add(new MailAddress("info@MyWebsiteDomainName"));
            //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

            smtpClient.Send(mail);
            //SmtpClient SMTPServer = new SmtpClient("127.0.0.1");
            //try
            //{
            //    SMTPServer.Send(mailObj);
            //}
            //catch (Exception ex)
            //{
            //    eror.InnerText = ex.ToString();// = "Message sending failed!"
            //}


            ////Response.Redirect("~/About");

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