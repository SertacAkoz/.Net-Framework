namespace PanoImalatlari
{
    partial class FormSil
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtSilinecek = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOnayla.Location = new System.Drawing.Point(309, 211);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(161, 23);
            this.btnOnayla.TabIndex = 76;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtSilinecek
            // 
            this.txtSilinecek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSilinecek.Location = new System.Drawing.Point(309, 173);
            this.txtSilinecek.Name = "txtSilinecek";
            this.txtSilinecek.Size = new System.Drawing.Size(161, 20);
            this.txtSilinecek.TabIndex = 75;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(306, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "Silinecek Pano NO Giriniz :";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 415);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 77;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FormSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtSilinecek);
            this.Controls.Add(this.label19);
            this.Name = "FormSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sil";
            this.Load += new System.EventHandler(this.FormSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        public System.Windows.Forms.TextBox txtSilinecek;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnGeri;
    }
}