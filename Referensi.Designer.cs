namespace SPUAS
{
    partial class Referensi
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
            this.gridBuku = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblkode = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBuku
            // 
            this.gridBuku.AllowUserToOrderColumns = true;
            this.gridBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuku.Location = new System.Drawing.Point(23, 58);
            this.gridBuku.Name = "gridBuku";
            this.gridBuku.Size = new System.Drawing.Size(903, 248);
            this.gridBuku.TabIndex = 0;
            this.gridBuku.DoubleClick += new System.EventHandler(this.gridBuku_DoubleClick);
            this.gridBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBuku_CellClick);
            this.gridBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBuku_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "UBAH REFERENSI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(342, 32);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(165, 20);
            this.txtKeyword.TabIndex = 3;
            this.txtKeyword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(20, 34);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(88, 13);
            this.lblCari.TabIndex = 4;
            this.lblCari.Text = "Cari Berdasarkan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Keyword";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Semua Kategori",
            "Kode Buku",
            "Nama Buku",
            "Penulis",
            "Penelaah",
            "Tahun Kisi",
            "Target"});
            this.cbKategori.Location = new System.Drawing.Point(115, 30);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 21);
            this.cbKategori.TabIndex = 6;
            this.cbKategori.Tag = "";
            this.cbKategori.Text = "-- Pilih Kategori --";
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // lblkode
            // 
            this.lblkode.AutoSize = true;
            this.lblkode.Location = new System.Drawing.Point(644, 34);
            this.lblkode.Name = "lblkode";
            this.lblkode.Size = new System.Drawing.Size(31, 13);
            this.lblkode.TabIndex = 7;
            this.lblkode.Text = "code";
            this.lblkode.Visible = false;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(191, 330);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(143, 23);
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Text = "INFORMASI DETAIL";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(851, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Referensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 370);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblkode);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridBuku);
            this.Name = "Referensi";
            this.Text = "Referensi";
            this.Load += new System.EventHandler(this.Referensi_Load);
            this.Click += new System.EventHandler(this.Referensi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gridBuku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori;
        public System.Windows.Forms.Label lblkode;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button button3;
    }
}