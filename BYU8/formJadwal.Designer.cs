namespace BYU8
{
    partial class formJadwal
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
            this.data1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Kode = new System.Windows.Forms.TextBox();
            this.Dari = new System.Windows.Forms.ComboBox();
            this.Ke = new System.Windows.Forms.ComboBox();
            this.Maskapai = new System.Windows.Forms.ComboBox();
            this.Waktu = new System.Windows.Forms.TextBox();
            this.Durasi = new System.Windows.Forms.TextBox();
            this.Harga = new System.Windows.Forms.NumericUpDown();
            this.Tanggal = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Jadwal Penerbangan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua jadwal penerbangan akan muncul di sin.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // data1
            // 
            this.data1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.data1.Location = new System.Drawing.Point(3, 78);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(1110, 179);
            this.data1.TabIndex = 2;
            this.data1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Penerbangan";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bandara Keberangkatan";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bandara Tujuan";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Maskapai";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tanggal Keberangkatan";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Waktu Keberangkatan";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Durasi Penerbangan";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Harga Per Tiket";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.Text = "Ubah";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.Text = "Hapus";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kode Penerbangan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dari\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ke";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Maskapai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(660, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tanggal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Waktu Keberangkatan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(661, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(661, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Harga Per Tiket";
            // 
            // Kode
            // 
            this.Kode.Location = new System.Drawing.Point(263, 289);
            this.Kode.Name = "Kode";
            this.Kode.Size = new System.Drawing.Size(195, 20);
            this.Kode.TabIndex = 11;
            this.Kode.Text = "__-______";
            // 
            // Dari
            // 
            this.Dari.FormattingEnabled = true;
            this.Dari.Location = new System.Drawing.Point(263, 319);
            this.Dari.Name = "Dari";
            this.Dari.Size = new System.Drawing.Size(195, 21);
            this.Dari.TabIndex = 12;
            this.Dari.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ke
            // 
            this.Ke.FormattingEnabled = true;
            this.Ke.Location = new System.Drawing.Point(264, 350);
            this.Ke.Name = "Ke";
            this.Ke.Size = new System.Drawing.Size(195, 21);
            this.Ke.TabIndex = 13;
            // 
            // Maskapai
            // 
            this.Maskapai.FormattingEnabled = true;
            this.Maskapai.Location = new System.Drawing.Point(264, 384);
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.Size = new System.Drawing.Size(195, 21);
            this.Maskapai.TabIndex = 14;
            // 
            // Waktu
            // 
            this.Waktu.Location = new System.Drawing.Point(830, 320);
            this.Waktu.Name = "Waktu";
            this.Waktu.Size = new System.Drawing.Size(195, 20);
            this.Waktu.TabIndex = 16;
            this.Waktu.Text = "00 : 00";
            // 
            // Durasi
            // 
            this.Durasi.Location = new System.Drawing.Point(830, 351);
            this.Durasi.Name = "Durasi";
            this.Durasi.Size = new System.Drawing.Size(195, 20);
            this.Durasi.TabIndex = 17;
            this.Durasi.Text = "__ Jam __ Menit";
            // 
            // Harga
            // 
            this.Harga.AllowDrop = true;
            this.Harga.Location = new System.Drawing.Point(830, 385);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(195, 20);
            this.Harga.TabIndex = 34;
            this.Harga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tanggal
            // 
            this.Tanggal.Location = new System.Drawing.Point(825, 289);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(200, 20);
            this.Tanggal.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(938, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 40;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tanggal);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Durasi);
            this.Controls.Add(this.Waktu);
            this.Controls.Add(this.Maskapai);
            this.Controls.Add(this.Ke);
            this.Controls.Add(this.Dari);
            this.Controls.Add(this.Kode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formJadwal";
            this.Text = "formJadwal";
            this.Load += new System.EventHandler(this.formJadwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Kode;
        private System.Windows.Forms.ComboBox Dari;
        private System.Windows.Forms.ComboBox Ke;
        private System.Windows.Forms.ComboBox Maskapai;
        private System.Windows.Forms.TextBox Waktu;
        private System.Windows.Forms.TextBox Durasi;
        private System.Windows.Forms.NumericUpDown Harga;
        private System.Windows.Forms.DateTimePicker Tanggal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}