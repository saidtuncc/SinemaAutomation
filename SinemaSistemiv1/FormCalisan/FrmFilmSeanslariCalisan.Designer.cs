namespace SinemaSistemiv1.FormCalisan
{
    partial class FrmFilmSeanslariCalisan
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
            panelFilmSeansCalisan = new Panel();
            SuspendLayout();
            // 
            // panelFilmSeansCalisan
            // 
            panelFilmSeansCalisan.BorderStyle = BorderStyle.FixedSingle;
            panelFilmSeansCalisan.Location = new Point(26, 23);
            panelFilmSeansCalisan.Name = "panelFilmSeansCalisan";
            panelFilmSeansCalisan.Size = new Size(532, 353);
            panelFilmSeansCalisan.TabIndex = 97;
            // 
            // FrmFilmSeanslariCalisan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFilmSeansCalisan);
            Name = "FrmFilmSeanslariCalisan";
            Text = "Film Seansları";
            Load += FrmFilmSeanslariCalisan_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFilmSeansCalisan;
    }
}