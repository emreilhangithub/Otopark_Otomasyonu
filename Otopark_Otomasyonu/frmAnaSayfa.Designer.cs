
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnAracOtoparkKayit = new System.Windows.Forms.Button();
            this.btnAracOtoparkYerleri = new System.Windows.Forms.Button();
            this.btnAracOtoparkCikis = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOtoparkCikisYapmisAraclar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAracOtoparkKayit
            // 
            this.btnAracOtoparkKayit.Location = new System.Drawing.Point(96, 34);
            this.btnAracOtoparkKayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAracOtoparkKayit.Name = "btnAracOtoparkKayit";
            this.btnAracOtoparkKayit.Size = new System.Drawing.Size(540, 35);
            this.btnAracOtoparkKayit.TabIndex = 0;
            this.btnAracOtoparkKayit.Text = "Araç Otopark Kaydı Sayfası";
            this.btnAracOtoparkKayit.UseVisualStyleBackColor = true;
            this.btnAracOtoparkKayit.Click += new System.EventHandler(this.btnAracOtoparkKayit_Click);
            // 
            // btnAracOtoparkYerleri
            // 
            this.btnAracOtoparkYerleri.Location = new System.Drawing.Point(96, 78);
            this.btnAracOtoparkYerleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAracOtoparkYerleri.Name = "btnAracOtoparkYerleri";
            this.btnAracOtoparkYerleri.Size = new System.Drawing.Size(540, 35);
            this.btnAracOtoparkYerleri.TabIndex = 1;
            this.btnAracOtoparkYerleri.Text = "Araç Otopark Yerleri";
            this.btnAracOtoparkYerleri.UseVisualStyleBackColor = true;
            this.btnAracOtoparkYerleri.Click += new System.EventHandler(this.btnAracOtoparkYerleri_Click);
            // 
            // btnAracOtoparkCikis
            // 
            this.btnAracOtoparkCikis.Location = new System.Drawing.Point(96, 123);
            this.btnAracOtoparkCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAracOtoparkCikis.Name = "btnAracOtoparkCikis";
            this.btnAracOtoparkCikis.Size = new System.Drawing.Size(540, 35);
            this.btnAracOtoparkCikis.TabIndex = 2;
            this.btnAracOtoparkCikis.Text = "Araç Otopark Çıkış Sayfası";
            this.btnAracOtoparkCikis.UseVisualStyleBackColor = true;
            this.btnAracOtoparkCikis.Click += new System.EventHandler(this.btnAracOtoparkCikis_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(96, 218);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(540, 35);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOtoparkCikisYapmisAraclar
            // 
            this.btnOtoparkCikisYapmisAraclar.Location = new System.Drawing.Point(96, 174);
            this.btnOtoparkCikisYapmisAraclar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOtoparkCikisYapmisAraclar.Name = "btnOtoparkCikisYapmisAraclar";
            this.btnOtoparkCikisYapmisAraclar.Size = new System.Drawing.Size(540, 35);
            this.btnOtoparkCikisYapmisAraclar.TabIndex = 4;
            this.btnOtoparkCikisYapmisAraclar.Text = "Otopark Çıkış Yapmış Araçlar";
            this.btnOtoparkCikisYapmisAraclar.UseVisualStyleBackColor = true;
            this.btnOtoparkCikisYapmisAraclar.Click += new System.EventHandler(this.btnOtoparkCikisYapmisAraclar_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(699, 297);
            this.Controls.Add(this.btnOtoparkCikisYapmisAraclar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAracOtoparkCikis);
            this.Controls.Add(this.btnAracOtoparkYerleri);
            this.Controls.Add(this.btnAracOtoparkKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Otopark Otomasyonu Ana Sayfa";
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

