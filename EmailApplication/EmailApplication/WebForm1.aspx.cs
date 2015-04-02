using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static void SendEmail(string body)
        {
            MailMessage mailMessage = new MailMessage("bernal011584@gmail.com", "bernal011584@gmail.com");
            mailMessage.Subject = "Testing Email";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;


            // all credetials are in the web.config
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string body = "";
            using (StreamReader reader = new StreamReader(Server.MapPath("EmailTemplate.html")))
            {
                body = reader.ReadToEnd();
            }
            SendEmail(body);
        }
    }
}