using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.IO;
using System.Web.UI;
using System.Configuration;


namespace EmailApplication
{
    public class MailingClass
    {
        public static void SendEmail()
        {
            string emailBody = "";
            MailMessage mailMessage = new MailMessage("bernal011584@gmail.com", "bernal011584@gmail.com");
            mailMessage.Subject = "Testing Email";
            using (StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("~/EmailTemplate.html")))
            {
                emailBody = reader.ReadToEnd();
            }
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = emailBody;

            
            // all credetials are in the web.config
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Send(mailMessage);
        }
        //public void call()
        //{
        //    SendEmail();
            
        //}
    }

    
    
}