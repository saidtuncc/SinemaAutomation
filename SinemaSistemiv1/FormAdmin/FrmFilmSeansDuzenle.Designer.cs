namespace SinemaSistemiv1.FrmAdmin
{
    partial class FrmFilmSeansDuzenle
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
            txtFilmBaslik = new TextBox();
            txtFilmSure = new TextBox();
            txtFilmTuru = new TextBox();
            rtxtFilmAciklama = new RichTextBox();
            BtnFilmEkle = new Button();
            BtnPosterYukle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnSeansEkle = new Button();
            dataGridView1 = new DataGridView();
            BtnDuzenle = new Button();
            BtnSil = new Button();
            ComboxFilmSecimi = new ComboBox();
            label7 = new Label();
            txtFilmRating = new TextBox();
            label8 = new Label();
            datetimeSeansSaati = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ComboxSalonSecimi = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilmBaslik
            // 
            txtFilmBaslik.Location = new Point(49, 74);
            txtFilmBaslik.Name = "txtFilmBaslik";
            txtFilmBaslik.Size = new Size(125, 27);
            txtFilmBaslik.TabIndex = 0;
            // 
            // txtFilmSure
            // 
            txtFilmSure.Location = new Point(213, 74);
            txtFilmSure.Name = "txtFilmSure";
            txtFilmSure.Size = new Size(125, 27);
            txtFilmSure.TabIndex = 1;
            // 
            // txtFilmTuru
            // 
            txtFilmTuru.Location = new Point(370, 74);
            txtFilmTuru.Name = "txtFilmTuru";
            txtFilmTuru.Size = new Size(125, 27);
            txtFilmTuru.TabIndex = 2;
            // 
            // rtxtFilmAciklama
            // 
            rtxtFilmAciklama.Location = new Point(49, 137);
            rtxtFilmAciklama.Name = "rtxtFilmAciklama";
            rtxtFilmAciklama.Size = new Size(125, 120);
            rtxtFilmAciklama.TabIndex = 3;
            rtxtFilmAciklama.Text = "";
            // 
            // BtnFilmEkle
            // 
            BtnFilmEkle.Location = new Point(49, 291);
            BtnFilmEkle.Name = "BtnFilmEkle";
            BtnFilmEkle.Size = new Size(94, 29);
            BtnFilmEkle.TabIndex = 4;
            BtnFilmEkle.Text = "Film Ekle";
            BtnFilmEkle.UseVisualStyleBackColor = true;
            BtnFilmEkle.Click += BtnFilmEkle_Click_1;
            // 
            // BtnPosterYukle
            // 
            BtnPosterYukle.Location = new Point(213, 291);
            BtnPosterYukle.Name = "BtnPosterYukle";
            BtnPosterYukle.Size = new Size(140, 29);
            BtnPosterYukle.TabIndex = 5;
            BtnPosterYukle.Text = "Poster Yükle";
            BtnPosterYukle.UseVisualStyleBackColor = true;
            BtnPosterYukle.Click += BtnPosterYukle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 39);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 6;
            label1.Text = "Film İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 39);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "Film Süresi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 39);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Film Türü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 114);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 9;
            label4.Text = "Film Konusu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 114);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 10;
            label5.Text = "Film Posteri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(744, 39);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "Seans Saati";
            // 
            // BtnSeansEkle
            // 
            BtnSeansEkle.Location = new Point(745, 271);
            BtnSeansEkle.Name = "BtnSeansEkle";
            BtnSeansEkle.Size = new Size(94, 29);
            BtnSeansEkle.TabIndex = 13;
            BtnSeansEkle.Text = "Seans Ekle";
            BtnSeansEkle.UseVisualStyleBackColor = true;
            BtnSeansEkle.Click += BtnSeansEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1130, 205);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnDuzenle
            // 
            BtnDuzenle.Location = new Point(91, 581);
            BtnDuzenle.Name = "BtnDuzenle";
            BtnDuzenle.Size = new Size(94, 29);
            BtnDuzenle.TabIndex = 15;
            BtnDuzenle.Text = "Düzenle";
            BtnDuzenle.UseVisualStyleBackColor = true;
            BtnDuzenle.Click += BtnDuzenle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(270, 581);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(94, 29);
            BtnSil.TabIndex = 16;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // ComboxFilmSecimi
            // 
            ComboxFilmSecimi.FormattingEnabled = true;
            ComboxFilmSecimi.Location = new Point(744, 152);
            ComboxFilmSecimi.Name = "ComboxFilmSecimi";
            ComboxFilmSecimi.Size = new Size(151, 28);
            ComboxFilmSecimi.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(743, 123);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 18;
            label7.Text = "Film Seçimi";
            // 
            // txtFilmRating
            // 
            txtFilmRating.Location = new Point(519, 78);
            txtFilmRating.Name = "txtFilmRating";
            txtFilmRating.Size = new Size(125, 27);
            txtFilmRating.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(531, 39);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 20;
            label8.Text = "Film Rating";
            // 
            // datetimeSeansSaati
            // 
            datetimeSeansSaati.Format = DateTimePickerFormat.Time;
            datetimeSeansSaati.Location = new Point(744, 72);
            datetimeSeansSaati.Name = "datetimeSeansSaati";
            datetimeSeansSaati.ShowUpDown = true;
            datetimeSeansSaati.Size = new Size(250, 27);
            datetimeSeansSaati.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(213, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 133);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // ComboxSalonSecimi
            // 
            ComboxSalonSecimi.FormattingEnabled = true;
            ComboxSalonSecimi.Location = new Point(743, 229);
            ComboxSalonSecimi.Name = "ComboxSalonSecimi";
            ComboxSalonSecimi.Size = new Size(151, 28);
            ComboxSalonSecimi.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(744, 193);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 24;
            label9.Text = "Salon Seçimi";
            // 
            // FrmFilmSeansDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 725);
            Controls.Add(label9);
            Controls.Add(ComboxSalonSecimi);
            Controls.Add(pictureBox1);
            Controls.Add(datetimeSeansSaati);
            Controls.Add(label8);
            Controls.Add(txtFilmRating);
            Controls.Add(label7);
            Controls.Add(ComboxFilmSecimi);
            Controls.Add(BtnSil);
            Controls.Add(BtnDuzenle);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSeansEkle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnPosterYukle);
            Controls.Add(BtnFilmEkle);
            Controls.Add(rtxtFilmAciklama);
            Controls.Add(txtFilmTuru);
            Controls.Add(txtFilmSure);
            Controls.Add(txtFilmBaslik);
            Name = "FrmFilmSeansDuzenle";
            Text = "Film Düzenleme";
            Load += FrmFilmSeansDuzenle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilmBaslik;
        private TextBox txtFilmSure;
        private TextBox txtFilmTuru;
        private RichTextBox rtxtFilmAciklama;
        private Button BtnFilmEkle;
        private Button BtnPosterYukle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnSeansEkle;
        private DataGridView dataGridView1;
        private Button BtnDuzenle;
        private Button BtnSil;
        private ComboBox ComboxFilmSecimi;
        private Label label7;
        private TextBox txtFilmRating;
        private Label label8;
        private DateTimePicker datetimeSeansSaati;
        private PictureBox pictureBox1;
        private ComboBox ComboxSalonSecimi;
        private Label label9;
    }
}