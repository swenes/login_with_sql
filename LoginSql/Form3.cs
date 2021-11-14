using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Data.SqlClient;

namespace LoginSql
{

    /*
      SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=deneme;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand command = new SqlCommand("Select * from [Table] where " +
            "adminEmail = '" + txtMail + "' and adminAd = '" + txtKullaniciAdi + "'", connection);

    */
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void mailGonder()
        {
            Random rnd = new Random();
            int sifre= rnd.Next(100, 999);

            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("enes_aydogdu2001@hotmail.com", "enes4116");    // Kendi mail adress ve şifreni girmek zorundasın.
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajım.To.Add("enes.aydogdu2488@gmail.com");                       // mesajın KİME gittiğini belirtir.
            mesajım.From = new MailAddress("enes_aydogdu2001@hotmail.com");    // mesajın KİMDEN gittiğini belirtir.
            mesajım.Subject = "ŞİFRE YENİLEME";
            mesajım.Body = "Belirlenen şifreniz: "+sifre;
            istemci.Send(mesajım);
            MessageBox.Show("Mail başarıyla gönderildi!");
        }
        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            mailGonder();

            }
    }
}