using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    public partial class pompa : Form
    {
        public pompa()
        {
            InitializeComponent();
        }

        private void pompa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet10.YakitVerileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yakitVerileriTableAdapter.Fill(this.petrol_otomasyonDataSet10.YakitVerileri);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet6.Pompake' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pompakeTableAdapter1.Fill(this.petrol_otomasyonDataSet6.Pompake);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet5.Pompake' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pompakeTableAdapter.Fill(this.petrol_otomasyonDataSet5.Pompake);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet4.PompaCihazlari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Giriş Girişform = new Giriş();
            Girişform.Show();  // Giriş formunu göster
            this.Hide();        // Ana sayfayı gizle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox değerlerini al
            string PompaIDStr = textBox1.Text;
            string PersonelAdi = textBox2.Text;
            string Plaka = textBox3.Text;
            string Tutar = textBox4.Text;
            string YakitMiktari = textBox5.Text;
            string YakitTipi = textBox6.Text;
            string OdemeTuru = textBox7.Text;
            string SubeIDStr = textBox8.Text;
            string YakitStok = textBox9.Text;  // Yakıt stoğu için bir TextBox ekledik

            // Veritabanı bağlantısı ve komut kullanımı
            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;";

            // Verileri kontrol et
            int PompaID, SubeID;
            decimal TutarDecimal, YakitMiktariDecimal, YakitStokDecimal;

            if (!int.TryParse(PompaIDStr, out PompaID))
            {
                MessageBox.Show("Geçersiz PompaID! Lütfen geçerli bir sayı girin.");
                return;
            }

            if (!int.TryParse(SubeIDStr, out SubeID))
            {
                MessageBox.Show("Geçersiz SubeID! Lütfen geçerli bir sayı girin.");
                return;
            }

            if (!decimal.TryParse(Tutar, out TutarDecimal))
            {
                MessageBox.Show("Geçersiz Tutar! Lütfen geçerli bir sayı girin.");
                return;
            }

            if (!decimal.TryParse(YakitMiktari, out YakitMiktariDecimal))
            {
                MessageBox.Show("Geçersiz Yakıt Miktarı! Lütfen geçerli bir sayı girin.");
                return;
            }

            if (!decimal.TryParse(YakitStok, out YakitStokDecimal))
            {
                MessageBox.Show("Geçersiz Yakıt Stoku! Lütfen geçerli bir sayı girin.");
                return;
            }

            // SQL bağlantısı ve ekleme işlemi
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO YakitVerileri (PompaID, PersonelAdi, Plaka, Tutar, YakitMiktari, YakitTipi, OdemeTuru, SubeID, YakitStok) " +
                                   "VALUES (@PompaID, @PersonelAdi, @Plaka, @Tutar, @YakitMiktari, @YakitTipi, @OdemeTuru, @SubeID, @YakitStok)";

                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@PompaID", PompaID);
                        cmd.Parameters.AddWithValue("@PersonelAdi", PersonelAdi);
                        cmd.Parameters.AddWithValue("@Plaka", Plaka);
                        cmd.Parameters.AddWithValue("@Tutar", TutarDecimal);
                        cmd.Parameters.AddWithValue("@YakitMiktari", YakitMiktariDecimal);
                        cmd.Parameters.AddWithValue("@YakitTipi", YakitTipi);
                        cmd.Parameters.AddWithValue("@OdemeTuru", OdemeTuru);
                        cmd.Parameters.AddWithValue("@SubeID", SubeID);
                        cmd.Parameters.AddWithValue("@YakitStok", YakitStokDecimal);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Yakıt Verisi Eklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }

        }
    }
}
