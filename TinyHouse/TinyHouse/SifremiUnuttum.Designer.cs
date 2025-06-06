namespace TinyHouse
{
    partial class SifremiUnuttum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniSifreKaydet = new System.Windows.Forms.Button();
            this.txtYSKullaniciAdi = new System.Windows.Forms.TextBox();
            this.mskYeniSifre = new System.Windows.Forms.MaskedTextBox();
            this.mskYeniSifreTekrar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // btnYeniSifreKaydet
            // 
            this.btnYeniSifreKaydet.Location = new System.Drawing.Point(152, 106);
            this.btnYeniSifreKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeniSifreKaydet.Name = "btnYeniSifreKaydet";
            this.btnYeniSifreKaydet.Size = new System.Drawing.Size(112, 32);
            this.btnYeniSifreKaydet.TabIndex = 3;
            this.btnYeniSifreKaydet.Text = "Kaydet";
            this.btnYeniSifreKaydet.UseVisualStyleBackColor = true;
            this.btnYeniSifreKaydet.Click += new System.EventHandler(this.btnYeniSifreKaydet_Click);
            // 
            // txtYSKullaniciAdi
            // 
            this.txtYSKullaniciAdi.Location = new System.Drawing.Point(133, 13);
            this.txtYSKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYSKullaniciAdi.Name = "txtYSKullaniciAdi";
            this.txtYSKullaniciAdi.Size = new System.Drawing.Size(148, 26);
            this.txtYSKullaniciAdi.TabIndex = 4;
            // 
            // mskYeniSifre
            // 
            this.mskYeniSifre.Location = new System.Drawing.Point(133, 42);
            this.mskYeniSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskYeniSifre.Name = "mskYeniSifre";
            this.mskYeniSifre.Size = new System.Drawing.Size(148, 26);
            this.mskYeniSifre.TabIndex = 5;
            // 
            // mskYeniSifreTekrar
            // 
            this.mskYeniSifreTekrar.Location = new System.Drawing.Point(133, 72);
            this.mskYeniSifreTekrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskYeniSifreTekrar.Name = "mskYeniSifreTekrar";
            this.mskYeniSifreTekrar.Size = new System.Drawing.Size(148, 26);
            this.mskYeniSifreTekrar.TabIndex = 6;
            // 
            // SifremiUnuttum
            // 
            this.AcceptButton = this.btnYeniSifreKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 149);
            this.Controls.Add(this.mskYeniSifreTekrar);
            this.Controls.Add(this.mskYeniSifre);
            this.Controls.Add(this.txtYSKullaniciAdi);
            this.Controls.Add(this.btnYeniSifreKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniSifreKaydet;
        private System.Windows.Forms.TextBox txtYSKullaniciAdi;
        private System.Windows.Forms.MaskedTextBox mskYeniSifre;
        private System.Windows.Forms.MaskedTextBox mskYeniSifreTekrar;
    }
}