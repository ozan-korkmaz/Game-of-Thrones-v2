namespace TinyHouse
{
    partial class UyeOl
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
            this.label4 = new System.Windows.Forms.Label();
            this.mskSifre = new System.Windows.Forms.MaskedTextBox();
            this.mskSifreTekrar = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "e-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol:";
            // 
            // mskSifre
            // 
            this.mskSifre.Location = new System.Drawing.Point(122, 82);
            this.mskSifre.Mask = "000000";
            this.mskSifre.Name = "mskSifre";
            this.mskSifre.Size = new System.Drawing.Size(68, 26);
            this.mskSifre.TabIndex = 5;
            this.mskSifre.ValidatingType = typeof(int);
            // 
            // mskSifreTekrar
            // 
            this.mskSifreTekrar.Location = new System.Drawing.Point(122, 114);
            this.mskSifreTekrar.Mask = "000000";
            this.mskSifreTekrar.Name = "mskSifreTekrar";
            this.mskSifreTekrar.Size = new System.Drawing.Size(68, 26);
            this.mskSifreTekrar.TabIndex = 7;
            this.mskSifreTekrar.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifre Tekrar:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(122, 12);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(180, 26);
            this.txtAdSoyad.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Ev Sahibi",
            "Kiracı"});
            this.cmbRol.Location = new System.Drawing.Point(122, 150);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 26);
            this.cmbRol.TabIndex = 10;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Location = new System.Drawing.Point(191, 182);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(128, 32);
            this.btnUyeOl.TabIndex = 11;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // UyeOl
            // 
            this.AcceptButton = this.btnUyeOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 230);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.mskSifreTekrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskSifre;
        private System.Windows.Forms.MaskedTextBox mskSifreTekrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnUyeOl;
    }
}