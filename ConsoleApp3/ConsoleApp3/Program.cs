using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        public static void EmailKuldes(string kuldoEmail, string kuldoJelszo, string cimzettEmail,
                                      string targy, string tartalom, string csatolmany)
        {
            var mail = new MailMessage(); //Simple Mail Transfer Protokol

            // setup mail

            mail.From = new MailAddress(kuldoEmail + "@gmail.com");
            mail.To.Add(cimzettEmail);
            mail.Subject = targy;
            mail.Body = tartalom;
            if (!String.IsNullOrEmpty(csatolmany)) mail.Attachments.Add(new Attachment(csatolmany));

            // setup smtp

            var smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(kuldoEmail, kuldoJelszo);
            smtp.EnableSsl = true; // secure socket layer

            // send
            try
            {
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine("hiba történt az email küldése során");
            }


        }

        static void Main(string[] args)
        {
            string pass = "Qjt{24:9";
            int prev = 0;
            string jelszo = "";
            foreach (var a in pass)
            {
               jelszo+=Convert.ToChar(Convert.ToInt32(a) - 1);
            }
            int time;
   
            while (true) {
                time = DateTime.Now.Minute;

                if (prev != time)
                {
                    EmailKuldes("kristofosztopani", jelszo, "osztopanikristof1521@gmail.com", "eltelt 1 perc", DateTime.Now.ToString(), null);
                    
                    prev = time;
                }
                Thread.Sleep(2000);
            }
        }
    }
}
