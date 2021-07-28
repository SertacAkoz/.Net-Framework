namespace PanoImalatlari
{
    partial class DataGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            this.tblCetinPanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cetinPanoDataSet = new PanoImalatlari.CetinPanoDataSet();
            this.tblCetinPanoTableAdapter = new PanoImalatlari.CetinPanoDataSetTableAdapters.tblCetinPanoTableAdapter();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetinPanoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCetinPanoBindingSource
            // 
            this.tblCetinPanoBindingSource.DataMember = "tblCetinPano";
            this.tblCetinPanoBindingSource.DataSource = this.cetinPanoDataSet;
            // 
            // cetinPanoDataSet
            // 
            this.cetinPanoDataSet.DataSetName = "CetinPanoDataSet";
            this.cetinPanoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCetinPanoTableAdapter
            // 
            this.tblCetinPanoTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 464);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1544, 446);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1567, 499);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGrid";
            this.Load += new System.EventHandler(this.DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCetinPanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetinPanoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CetinPanoDataSet cetinPanoDataSet;
        private System.Windows.Forms.BindingSource tblCetinPanoBindingSource;
        private CetinPanoDataSetTableAdapters.tblCetinPanoTableAdapter tblCetinPanoTableAdapter;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}