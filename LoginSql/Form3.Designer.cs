
namespace LoginSql
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbladminKullanıcıadı = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnMailGonder = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladminKullanıcıadı
            // 
            this.lbladminKullanıcıadı.AutoSize = true;
            this.lbladminKullanıcıadı.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbladminKullanıcıadı.Location = new System.Drawing.Point(46, 74);
            this.lbladminKullanıcıadı.Name = "lbladminKullanıcıadı";
            this.lbladminKullanıcıadı.Size = new System.Drawing.Size(135, 28);
            this.lbladminKullanıcıadı.TabIndex = 0;
            this.lbladminKullanıcıadı.Text = "Kullanıcı adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(201, 75);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(518, 27);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.BackColor = System.Drawing.Color.Crimson;
            this.btnMailGonder.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMailGonder.Location = new System.Drawing.Point(249, 210);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(314, 67);
            this.btnMailGonder.TabIndex = 2;
            this.btnMailGonder.Text = "MAİL GÖNDER";
            this.btnMailGonder.UseVisualStyleBackColor = false;
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(201, 137);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(518, 27);
            this.txtMail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(46, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(149, 28);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-Mail Adress:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(752, 333);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnMailGonder);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lbladminKullanıcıadı);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladminKullanıcıadı;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnMailGonder;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmail;
    }
}