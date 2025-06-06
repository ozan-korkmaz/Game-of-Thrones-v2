namespace TinyHouse
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.linkLabelUyeOl = new System.Windows.Forms.LinkLabel();
            this.linkLabelSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.mskSifre = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(396, 157);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(148, 26);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // linkLabelUyeOl
            // 
            this.linkLabelUyeOl.AutoSize = true;
            this.linkLabelUyeOl.Location = new System.Drawing.Point(391, 225);
            this.linkLabelUyeOl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelUyeOl.Name = "linkLabelUyeOl";
            this.linkLabelUyeOl.Size = new System.Drawing.Size(57, 18);
            this.linkLabelUyeOl.TabIndex = 4;
            this.linkLabelUyeOl.TabStop = true;
            this.linkLabelUyeOl.Text = "Üye Ol";
            this.linkLabelUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUyeOl_LinkClicked);
            // 
            // linkLabelSifremiUnuttum
            // 
            this.linkLabelSifremiUnuttum.AutoSize = true;
            this.linkLabelSifremiUnuttum.Location = new System.Drawing.Point(458, 225);
            this.linkLabelSifremiUnuttum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            this.linkLabelSifremiUnuttum.Size = new System.Drawing.Size(128, 18);
            this.linkLabelSifremiUnuttum.TabIndex = 5;
            this.linkLabelSifremiUnuttum.TabStop = true;
            this.linkLabelSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linkLabelSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSifremiUnuttum_LinkClicked);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(564, 180);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(111, 31);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // mskSifre
            // 
            this.mskSifre.Location = new System.Drawing.Point(394, 193);
            this.mskSifre.Mask = "000000";
            this.mskSifre.Name = "mskSifre";
            this.mskSifre.Size = new System.Drawing.Size(150, 26);
            this.mskSifre.TabIndex = 7;
            this.mskSifre.ValidatingType = typeof(int);
            // 
            // Login
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 513);
            this.Controls.Add(this.mskSifre);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.linkLabelSifremiUnuttum);
            this.Controls.Add(this.linkLabelUyeOl);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.LinkLabel linkLabelUyeOl;
        private System.Windows.Forms.LinkLabel linkLabelSifremiUnuttum;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.MaskedTextBox mskSifre;
    }
}

