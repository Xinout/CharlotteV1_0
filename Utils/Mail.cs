using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.IO;
using System.Configuration;

namespace Utils
{
    public static class Mail
    {
        public static bool sendMail()
        {
            try
            {
                MailMessage mail = new MailMessage(ConfigurationManager.AppSettings["USER"].ToString(), ConfigurationManager.AppSettings["CORREO_ERRORES"].ToString());
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["USER"].ToString(), ConfigurationManager.AppSettings["PASS"].ToString());
                client.Host = "smtp.gmail.com";
                mail.Subject = "Mantenimiento Charlotte";
                mail.Body = "ERROR, ver fichero adjunto";
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.Attachments.Add(new Attachment(@"C:\\CharlotteV1_0\log_CHARLOTTE.txt"));
                client.Send(mail);

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public static bool backup()
        {
            try
            {
                string path = ConfigurationManager.AppSettings["BackupPath"].ToString();
                string fecha = DateTime.Now.Year + string.Format("{0:00}",DateTime.Now.Month) + string.Format("{0:00}",DateTime.Now.Day + "_" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second);
                string sourcePath = @"CharlotteBBDD.sqlite";
                string destinationPath =  path + fecha + ".sqlite";
                File.Copy(sourcePath, destinationPath);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void gestionaError(string error)
        {
            File.AppendAllText("log_CHARLOTTE.txt", DateTime.Now.ToLongDateString() + " - " + error + "\n", Encoding.UTF8);
            
        }
    }
}
