using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SinemaSistemiv1.FormCalisan
{
    public partial class FrmBiletIptal : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;";

        public FrmBiletIptal()
        {
            InitializeComponent();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            int biletId;
            if (int.TryParse(txtBiletId.Text, out biletId))
            {
                try
                {
                    using (var conn = new MySqlConnection(_connectionString))
                    {
                        conn.Open();

                        
                        string checkQuery = "SELECT koltuk_numarasi FROM biletler WHERE bilet_id = @Bilet_ID";
                        using (var checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@Bilet_ID", biletId);
                            var koltukNumarasi = checkCmd.ExecuteScalar();

                            if (koltukNumarasi != null)
                            {
                                
                                if (!string.IsNullOrEmpty(koltukNumarasi.ToString()))
                                {
                                    string updateQuery = "UPDATE koltuklar SET durum = 'bos' WHERE koltuk_id = @Koltuk_ID";
                                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                                    {
                                        updateCmd.Parameters.AddWithValue("@Koltuk_ID", koltukNumarasi.ToString());
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }

                                
                                string deleteQuery = "DELETE FROM biletler WHERE bilet_id = @Bilet_ID";
                                using (var deleteCmd = new MySqlCommand(deleteQuery, conn))
                                {
                                    deleteCmd.Parameters.AddWithValue("@Bilet_ID", biletId);
                                    deleteCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Bilet başarıyla iptal edildi.");
                            }
                            else
                            {
                                MessageBox.Show("Bilet bulunamadı.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir Bilet ID giriniz.");
            }
        }

        private void FrmBiletIptal_Load(object sender, EventArgs e)
        {

        }
    }
}
