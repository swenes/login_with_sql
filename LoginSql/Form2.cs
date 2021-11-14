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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.gonderilecekAdminAdSoyad;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++) {
                for (int z = 0; z < 100; z++)
                {

                    if (z == 99) { timer1.Stop(); }

                    else
                    {
                        int x = label1.Location.X + 1;
                        int y = label1.Location.Y + 1;

                        label1.Location = new Point(x, y);


                    }
                }



                
            
            }
        }
    }
}
