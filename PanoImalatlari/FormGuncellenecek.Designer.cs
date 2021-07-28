namespace PanoImalatlari
{
    partial class FormGuncellenecek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuncellenecek));
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtGuncellenecek = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOnayla.Location = new System.Drawing.Point(301, 191);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(161, 23);
            this.btnOnayla.TabIndex = 73;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtGuncellenecek
            // 
            this.txtGuncellenecek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGuncellenecek.Location = new System.Drawing.Point(301, 153);
            this.txtGuncellenecek.Name = "txtGuncellenecek";
            this.txtGuncellenecek.Size = new System.Drawing.Size(161, 20);
            this.txtGuncellenecek.TabIndex = 72;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(298, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 13);
            this.label19.TabIndex = 71;
            this.label19.Text = "Günellenecek Pano NO Giriniz :";
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGeri.Location = new System.Drawing.Point(12, 415);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 74;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FormGuncellenecek
            // 
            this.AcceptButton = this.btnOnayla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtGuncellenecek);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGuncellenecek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncellenecek Pano";
            this.Load += new System.EventHandler(this.FormGuncellenecek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtGuncellenecek;
        private System.Windows.Forms.Button btnGeri;
    }
}