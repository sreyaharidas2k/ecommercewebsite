using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ecommercewebsite
{
    public partial class adminreplyfeedback : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select User_Email from User_tb where User_Id=" + Session["uid"] + "";
                SqlDataReader dr = obj.fn_reader(sel);
                
                while (dr.Read())
                {
                   
                    TextBox1.Text = dr["User_Email"].ToString();
                }
               

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SendEmail2("sreya", "sreyathu2310@gmail.com","nqcm xsrw gvxz jogh", "Ashok", "sreyathu2310@gmail.com", "haii..", "test");

            string up = "update Feedback_tb set Reply_Msg='" + TextBox2.Text + "',Feedback_Status=1 where Feedback_Id=" + Session["fid"] + "";
            int updfeedbacktb = obj.fn_nonquery(up);
        }
        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}