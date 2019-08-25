using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKuldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void EmailKuldes(string kuldoEmail, string kuldoJelszo, string cimzettEmail,
                                       string targy, string tartalom, string csatolmany)
        {
            var mail = new MailMessage(); //Simple Mail Transfer Protokol

            // setup mail

            mail.From = new MailAddress(kuldoEmail+"@gmail.com");
            mail.To.Add(cimzettEmail);
            mail.Subject = targy;
            mail.Body = tartalom;
            if (!String.IsNullOrEmpty(csatolmany)) mail.Attachments.Add(new Attachment(csatolmany));

            // setup smtp

            var smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(kuldoEmail,kuldoJelszo);
            smtp.EnableSsl = true; // secure socket layer

            // send
            try
            {
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                MessageBox.Show("hiba történt az email küldése során");
            }


        }

        private void csatolmanyButton_Click(object sender, EventArgs e)
        {
            var talloz = new OpenFileDialog();
            csatolmanyTextBox.Text = (talloz.ShowDialog() == DialogResult.OK) ? talloz.FileName:"";

            /*
            DialogResult eredmeny = talloz.ShowDialog();
            if( eredmeny == DialogResult.OK)
            {
                csatolmanyTextBox.Text = talloz.FileName;
            }
            */
        }

        private void send_Click(object sender, EventArgs e)
        {
            EmailKuldes(kuldoTextBox.Text, jelszoTextBox.Text, cimzettToTextBox.Text,
                        targyTextBox.Text, szovegTextBox.Text, csatolmanyTextBox.Text);
        }
    }
}
