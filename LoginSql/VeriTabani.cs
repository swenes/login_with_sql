using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;







namespace LoginSql
{
    class VeriTabani
    {
        SqlConnection connection = new SqlConnection(@"Data source = (localdb)\MSSQLLocalDB;initial catalog=deneme;integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        public void GirisYap(string ad, string sifre, Form1 frm1) {

            command = new SqlCommand("Select * from [Table] where " +
            "adminAd = '" + ad + "' and adminSifre = '" + sifre + "'", connection);

            connection.Open();

            reader = command.ExecuteReader();
            if (reader.Read()) {

                MessageBox.Show("Giriş Başarılı !", "Tebrikler.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.gonderilecekAdminAdSoyad = reader["adminAdSoyad"].ToString();
                Form2 frm2 = new Form2();
                frm1.Hide();
                frm2.ShowDialog();
                
            }

            else {
                frm1.BackColor=Color.Blue;
                MessageBox.Show("Hatalı Giriş !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm1.BackColor = Color.SeaGreen;
            }
            connection.Close();
            command.Dispose();

        
        
        
        
        
        }



    }
}
