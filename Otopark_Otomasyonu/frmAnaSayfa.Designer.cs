
namespace Otopark_Otomasyonu
{
    partial class frmAnaSayfa
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
            this.btnAracOtoparkKayit = new System.Windows.Forms.Button();
            this.btnAracOtoparkYerleri = new System.Windows.Forms.Button();
            this.btnAracOtoparkCikis = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOtoparkCikisYapmisAraclar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAracOtoparkKayit
            // 
            this.btnAracOtoparkKayit.Location = new System.Drawing.Point(64, 22);
            this.btnAracOtoparkKayit.Name = "btnAracOtoparkKayit";
            this.btnAracOtoparkKayit.Size = new System.Drawing.Size(360, 23);
            this.btnAracOtoparkKayit.TabIndex = 0;
            this.btnAracOtoparkKayit.Text = "Araç Otapark Kaydı Sayfası";
            this.btnAracOtoparkKayit.UseVisualStyleBackColor = true;
            this.btnAracOtoparkKayit.Click += new System.EventHandler(this.btnAracOtoparkKayit_Click);
            // 
            // btnAracOtoparkYerleri
            // 
            this.btnAracOtoparkYerleri.Location = new System.Drawing.Point(64, 51);
            this.btnAracOtoparkYerleri.Name = "btnAracOtoparkYerleri";
            this.btnAracOtoparkYerleri.Size = new System.Drawing.Size(360, 23);
            this.btnAracOtoparkYerleri.TabIndex = 1;
            this.btnAracOtoparkYerleri.Text = "Araç Otapark Yerleri";
            this.btnAracOtoparkYerleri.UseVisualStyleBackColor = true;
            this.btnAracOtoparkYerleri.Click += new System.EventHandler(this.btnAracOtoparkYerleri_Click);
            // 
            // btnAracOtoparkCikis
            // 
            this.btnAracOtoparkCikis.Location = new System.Drawing.Point(64, 80);
            this.btnAracOtoparkCikis.Name = "btnAracOtoparkCikis";
            this.btnAracOtoparkCikis.Size = new System.Drawing.Size(360, 23);
            this.btnAracOtoparkCikis.TabIndex = 2;
            this.btnAracOtoparkCikis.Text = "Araç Otapark Çıkış Sayfası";
            this.btnAracOtoparkCikis.UseVisualStyleBackColor = true;
            this.btnAracOtoparkCikis.Click += new System.EventHandler(this.btnAracOtoparkCikis_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(64, 142);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(360, 23);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOtoparkCikisYapmisAraclar
            // 
            this.btnOtoparkCikisYapmisAraclar.Location = new System.Drawing.Point(64, 113);
            this.btnOtoparkCikisYapmisAraclar.Name = "btnOtoparkCikisYapmisAraclar";
            this.btnOtoparkCikisYapmisAraclar.Size = new System.Drawing.Size(360, 23);
            this.btnOtoparkCikisYapmisAraclar.TabIndex = 4;
            this.btnOtoparkCikisYapmisAraclar.Text = "Otopark Çıkış Yapmış Araçlar";
            this.btnOtoparkCikisYapmisAraclar.UseVisualStyleBackColor = true;
            this.btnOtoparkCikisYapmisAraclar.Click += new System.EventHandler(this.btnOtoparkCikisYapmisAraclar_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(466, 193);
            this.Controls.Add(this.btnOtoparkCikisYapmisAraclar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAracOtoparkCikis);
            this.Controls.Add(this.btnAracOtoparkYerleri);
            this.Controls.Add(this.btnAracOtoparkKayit);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Otopark Otamasyonu Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracOtoparkKayit;
        private System.Windows.Forms.Button btnAracOtoparkYerleri;
        private System.Windows.Forms.Button btnAracOtoparkCikis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOtoparkCikisYapmisAraclar;
    }
}

