namespace SinemaSistemiv1.FormKullanıcı
{
    partial class FrmFilmSeanslarıKullanici
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
            panelFilmSeans = new Panel();
            SuspendLayout();
            // 
            // panelFilmSeans
            // 
            panelFilmSeans.BorderStyle = BorderStyle.FixedSingle;
            panelFilmSeans.Location = new Point(24, 31);
            panelFilmSeans.Name = "panelFilmSeans";
            panelFilmSeans.Size = new Size(511, 353);
            panelFilmSeans.TabIndex = 96;
            // 
            // FrmFilmSeanslarıKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1424, 698);
            Controls.Add(panelFilmSeans);
            Name = "FrmFilmSeanslarıKullanici";
            Text = "Film Seansları";
            Load += FrmFilmSeanslarıKullanici_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFilmSeans;
    }
}