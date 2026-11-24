namespace PRAKTIKUM2_DESKTOP_XII_0081980338_MUHAMAD_RAFAEL
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.kode_barang = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.harga_satuan = new System.Windows.Forms.TextBox();
            this.satuan = new System.Windows.Forms.TextBox();
            this.stok = new System.Windows.Forms.TextBox();
            this.batas_minimun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(266, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(275, 168);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(266, 257);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 2;
            this.btntambah.Text = "tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(366, 257);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(75, 23);
            this.btnubah.TabIndex = 3;
            this.btnubah.Text = "ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(466, 257);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 4;
            this.btnhapus.Text = "hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // kode_barang
            // 
            this.kode_barang.Location = new System.Drawing.Point(22, 77);
            this.kode_barang.Name = "kode_barang";
            this.kode_barang.Size = new System.Drawing.Size(178, 20);
            this.kode_barang.TabIndex = 6;
            this.kode_barang.TextChanged += new System.EventHandler(this.kode_barang_TextChanged);
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Items.AddRange(new object[] {
            "\'Vitamin & Mineral\'",
            "\'Herbal Sehat\'",
            "\'Alat Kesehatan\'",
            "\'Perawatan Luka\'"});
            this.kategori.Location = new System.Drawing.Point(22, 155);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(178, 21);
            this.kategori.TabIndex = 7;
            this.kategori.Text = "pilh kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "kelola persediaan suplemen";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(22, 116);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(178, 20);
            this.nama_barang.TabIndex = 9;
            // 
            // harga_satuan
            // 
            this.harga_satuan.Location = new System.Drawing.Point(22, 273);
            this.harga_satuan.Name = "harga_satuan";
            this.harga_satuan.Size = new System.Drawing.Size(178, 20);
            this.harga_satuan.TabIndex = 10;
            // 
            // satuan
            // 
            this.satuan.Location = new System.Drawing.Point(22, 234);
            this.satuan.Name = "satuan";
            this.satuan.Size = new System.Drawing.Size(178, 20);
            this.satuan.TabIndex = 11;
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(22, 195);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(178, 20);
            this.stok.TabIndex = 12;
            // 
            // batas_minimun
            // 
            this.batas_minimun.Location = new System.Drawing.Point(22, 312);
            this.batas_minimun.Name = "batas_minimun";
            this.batas_minimun.Size = new System.Drawing.Size(178, 20);
            this.batas_minimun.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ketegori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kode Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Batas Minimum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Harga Satuan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Satuan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.batas_minimun);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.satuan);
            this.Controls.Add(this.harga_satuan);
            this.Controls.Add(this.nama_barang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.kode_barang);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.TextBox kode_barang;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.TextBox harga_satuan;
        private System.Windows.Forms.TextBox satuan;
        private System.Windows.Forms.TextBox stok;
        private System.Windows.Forms.TextBox batas_minimun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

