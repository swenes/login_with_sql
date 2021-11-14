using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string gonderilecekAdminAdSoyad;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Gold;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Crimson;
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            txt.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void grpAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void txtSifre_VisibleChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAd =txtAd.Text;
            string kullaniciSifre = txtSifre.Text;
            
            VeriTabani islemim = new VeriTabani();
            islemim.GirisYap(kullaniciAd,kullaniciSifre,this); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   Form3 frm3 = new Form3();
            this.Hide();
            
            frm3.Show();
        }
    }
}
