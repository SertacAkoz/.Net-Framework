namespace PanoImalatlari
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.btnRevize = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnFirmaGoster = new System.Windows.Forms.Button();
            this.btnFormBiten = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBilgi
            // 
            this.btnBilgi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBilgi.Location = new System.Drawing.Point(260, 12);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(163, 31);
            this.btnBilgi.TabIndex = 0;
            this.btnBilgi.Text = "Bilgileri Gir";
            this.btnBilgi.UseVisualStyleBackColor = false;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrid.Location = new System.Drawing.Point(260, 86);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(163, 31);
            this.btnGrid.TabIndex = 1;
            this.btnGrid.Text = "Data Grid";
            this.btnGrid.UseVisualStyleBackColor = false;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnRevize
            // 
            this.btnRevize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRevize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRevize.Location = new System.Drawing.Point(260, 49);
            this.btnRevize.Name = "btnRevize";
            this.btnRevize.Size = new System.Drawing.Size(163, 31);
            this.btnRevize.TabIndex = 2;
            this.btnRevize.Text = "Revize";
            this.btnRevize.UseVisualStyleBackColor = false;
            this.btnRevize.Click += new System.EventHandler(this.btnRevize_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKapat.Location = new System.Drawing.Point(260, 300);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(163, 31);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Programı Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnFirmaGoster
            // 
            this.btnFirmaGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFirmaGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFirmaGoster.Location = new System.Drawing.Point(260, 123);
            this.btnFirmaGoster.Name = "btnFirmaGoster";
            this.btnFirmaGoster.Size = new System.Drawing.Size(163, 31);
            this.btnFirmaGoster.TabIndex = 4;
            this.btnFirmaGoster.Text = "Firma Adına Göre Panoları Göster";
            this.btnFirmaGoster.UseVisualStyleBackColor = false;
            this.btnFirmaGoster.Click += new System.EventHandler(this.btnFirmaGoster_Click);
            // 
            // btnFormBiten
            // 
            this.btnFormBiten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFormBiten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFormBiten.Location = new System.Drawing.Point(260, 160);
            this.btnFormBiten.Name = "btnFormBiten";
            this.btnFormBiten.Size = new System.Drawing.Size(163, 31);
            this.btnFormBiten.TabIndex = 5;
            this.btnFormBiten.Text = "Biten İşler";
            this.btnFormBiten.UseVisualStyleBackColor = false;
            this.btnFormBiten.Click += new System.EventHandler(this.btnFormBiten_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Location = new System.Drawing.Point(260, 263);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(163, 31);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Pano Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnFormBiten);
            this.Controls.Add(this.btnFirmaGoster);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnRevize);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.btnBilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button btnRevize;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnFirmaGoster;
        private System.Windows.Forms.Button btnFormBiten;
        private System.Windows.Forms.Button btnSil;
    }
}

