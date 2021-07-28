namespace PanoImalatlari
{
    partial class FormAra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAra));
            this.tblCetinPanoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cetinPanoDataSet = new PanoImalatlari.CetinPanoDataSet();
            this.tblCetinPanoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCetinPanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCetinPanoTableAdapter = new PanoImalatlari.CetinPanoDataSetTableAdapters.tblCetinPanoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetinPanoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCetinPanoBindingSource2
            // 
            this.tblCetinPanoBindingSource2.DataMember = "tblCetinPano";
            this.tblCetinPanoBindingSource2.DataSource = this.cetinPanoDataSet;
            // 
            // cetinPanoDataSet
            // 
            this.cetinPanoDataSet.DataSetName = "CetinPanoDataSet";
            this.cetinPanoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCetinPanoBindingSource1
            // 
            this.tblCetinPanoBindingSource1.DataMember = "tblCetinPano";
            this.tblCetinPanoBindingSource1.DataSource = this.cetinPanoDataSet;
            // 
            // tblCetinPanoBindingSource
            // 
            this.tblCetinPanoBindingSource.DataMember = "tblCetinPano";
            this.tblCetinPanoBindingSource.DataSource = this.cetinPanoDataSet;
            // 
            // tblCetinPanoTableAdapter
            // 
            this.tblCetinPanoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranacak Firma Adını Giriniz :";
            // 
            // txtAranacak
            // 
            this.txtAranacak.Location = new System.Drawing.Point(163, 13);
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(100, 20);
            this.txtAranacak.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(270, 13);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 20);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 415);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1543, 370);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // FormAra
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1560, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranacak);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Adı Ara";
            this.Load += new System.EventHandler(this.FormAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetinPanoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CetinPanoDataSet cetinPanoDataSet;
        private System.Windows.Forms.BindingSource tblCetinPanoBindingSource;
        private CetinPanoDataSetTableAdapters.tblCetinPanoTableAdapter tblCetinPanoTableAdapter;
        private System.Windows.Forms.BindingSource tblCetinPanoBindingSource1;
        private System.Windows.Forms.BindingSource tblCetinPanoBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}