using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Recovery_password : Form
    {
        Thread t, t2;
        public Recovery_password()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(this.Send_Mail));
            t.IsBackground = true;
            t2 = new Thread(new ThreadStart(loading));
            t2.IsBackground = true;
            t2.Start();
            t.Start();
        }

        private void loading()
        {
            Loading load = new Loading();
            load.ShowDialog();
        }

        private void piCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Mail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient server = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("waveershad21@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Body = txtName.Text+""+"\n "+"سلام این ایمیل جهت بازیابی رمز عبور شما می باشد " + "\n" + Properties.Settings.Default.Password;
                mail.Subject = "App-Project";

                server.Port = 587;
                server.Credentials = new System.Net.NetworkCredential("waveershad21@gmail.com", "abcdeabcde4513461374138213xyzpqr");
                server.EnableSsl = true;
                server.Send(mail);
                // MessageBox.Show("Message sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
