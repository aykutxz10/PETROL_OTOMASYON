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
    public partial class personel : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        private DataTable personelTable;
        public personel()
        {
            InitializeComponent();
            // Personel tablosu ve DataGridView'e veri kaynağını bağlamak
            personelTable = new DataTable();

            // DataTable'a sütunları ekliyoruz
            personelTable.Columns.Add("Isim", typeof(string));
            personelTable.Columns.Add("Soyisim", typeof(string));
            personelTable.Columns.Add("Pozisyon", typeof(string));
            personelTable.Columns.Add("MesaiBaslangicSaati", typeof(string));
            personelTable.Columns.Add("MesaiBitisSaati", typeof(string));
            personelTable.Columns.Add("SaatlikUcret", typeof(string));
            personelTable.Columns.Add("Maas", typeof(string));
            personelTable.Columns.Add("SubeID", typeof(string));


        }

        // Ekleme işlemi
        private void button2_Click(object sender, EventArgs e)
        {
            // TextBox değerlerini al
            string Isim = textBox1.Text;
            string Soyisim = textBox2.Text;
            string Pozisyon = textBox3.Text;
            string MesaiBaslangicSaati = textBox4.Text;
            string MesaiBitisSaati = textBox5.Text;
            string Maas = textBox6.Text;
            string SaatlikUcret = textBox7.Text;
            string subeIDStr = textBox8.Text;

            // SubeID'nin geçerli bir sayı olup olmadığını kontrol et
            int subeID;
            if (!int.TryParse(subeIDStr, out subeID))
            {
                MessageBox.Show("Geçersiz SubeID! Lütfen geçerli bir sayı girin.");
                return; // Geçersiz SubeID olduğunda işlemi durdur
            }




            // SQL bağlantısı ve komut kullanımı
            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO Personeller (Isim, Soyisim, Pozisyon, MesaiBaslangicSaati, MesaiBitisSaati,Maas,SaatlikUcret,subeIDStr) " +
                                   "VALUES ( @Isim, @Soyisim, @Pozisyon, @MesaiBaslangicSaati, @MesaiBitisSaati,@Maas,@SaatlikUcret,@subeID";

                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {

                        cmd.Parameters.AddWithValue("@Isim", Isim);
                        cmd.Parameters.AddWithValue("@Soyisim", Soyisim);
                        cmd.Parameters.AddWithValue("@Pozisyon", Pozisyon);
                        cmd.Parameters.AddWithValue("@MesaiBaslangicSaati", MesaiBaslangicSaati);
                        cmd.Parameters.AddWithValue("@MesaiBitisSaati", MesaiBitisSaati);
                        cmd.Parameters.AddWithValue("@Maas", Maas);
                        cmd.Parameters.AddWithValue("@SaatlikUcret", SaatlikUcret);
                        cmd.Parameters.AddWithValue("@SubeID", subeIDStr);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Personel Eklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
        // DataGridView tıklama olayında, DataGridView'e veri eklemeye gerek yok, zaten DataTable'dan veri çekiliyor.

        private void personel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet8.Personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellerTableAdapter1.Fill(this.petrol_otomasyonDataSet8.Personeller);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Arama metni değiştikçe veritabanından veri çekiyoruz
            string searchText = textBox9.Text; // TextBox9'dan alınan arama metni
            AramaYap(searchText);
        }
        private void AramaYap(string searchText)
        {
            string isim = textBox9.Text;

            try
            {
                // SQL sorgusunu oluşturuyoruz
                string sorgu = "SELECT * FROM Personeller WHERE Isim LIKE @isim";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@isim", "%" + searchText + "%"); // LIKE operatörü ile esnek arama

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); // Veritabanından alınan veriyi tutacak DataTable
                dataAdapter.Fill(dt); // DataTable'a veriyi yüklüyoruz

                // DataGridView'e sonuçları bağlıyoruz
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); // Hata mesajı gösteriyoruz
            }
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giriş Girişform = new Giriş();
            Girişform.Show();  // Giriş formunu göster
            this.Hide();        // Ana sayfayı gizle
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TextBox değerini al
            string personelIDStr = textBox1.Text;  // Silmek istediğiniz personelin ID'si

            // PersonelID'nin geçerli bir sayı olup olmadığını kontrol et
            int personelID;
            if (!int.TryParse(personelIDStr, out personelID))
            {
                MessageBox.Show("Geçersiz PersonelID! Lütfen geçerli bir sayı girin.");
                return; // Geçersiz PersonelID olduğunda işlemi durdur
            }

            // SQL bağlantısı ve komut kullanımı
            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // PersonelID'ye göre veri silme sorgusu
                    string sorgu = "DELETE FROM Personeller WHERE PersonelID = @PersonelID";

                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        // Parametre ekleyerek SQL enjeksiyonunu engelle
                        cmd.Parameters.AddWithValue("@PersonelID", personelID);

                        // Komutu çalıştır ve etkilenen satır sayısını al
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Personel başarıyla silindi!");
                        }
                        else
                        {
                            MessageBox.Show("Silinecek personel bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // TextBox değerlerini al
            string Isim = textBox1.Text;
            string Soyisim = textBox2.Text;
            string Pozisyon = textBox3.Text;
            string MesaiBaslangicSaati = textBox4.Text;
            string MesaiBitisSaati = textBox5.Text;
            string Maas = textBox6.Text;
            string SaatlikUcret = textBox7.Text;
            string subeIDStr = textBox8.Text;

            // PersonelID'yi TextBox'dan alıyoruz
            int personelID;
            if (!int.TryParse(textBox10.Text, out personelID))
            {
                MessageBox.Show("Lütfen geçerli bir PersonelID girin.");
                return;
            }

            // SubeID'nin geçerli bir sayı olup olmadığını kontrol et
            int subeID;
            if (!int.TryParse(subeIDStr, out subeID))
            {
                MessageBox.Show("Geçersiz SubeID! Lütfen geçerli bir sayı girin.");
                return;
            }

            // SQL bağlantısı ve komut kullanımı
            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Güncelleme SQL sorgusu
                    string sorgu = "UPDATE Personeller SET Isim = @Isim, Soyisim = @Soyisim, Pozisyon = @Pozisyon, " +
                                   "MesaiBaslangicSaati = @MesaiBaslangicSaati, MesaiBitisSaati = @MesaiBitisSaati, " +
                                   "Maas = @Maas, SaatlikUcret = @SaatlikUcret, subeID = @subeID " +
                                   "WHERE PersonelID = @PersonelID"; // PersonelID ile eşleşen kaydı güncelliyoruz

                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        // Parametreleri komuta ekleyelim
                        cmd.Parameters.AddWithValue("@Isim", Isim);
                        cmd.Parameters.AddWithValue("@Soyisim", Soyisim);
                        cmd.Parameters.AddWithValue("@Pozisyon", Pozisyon);
                        cmd.Parameters.AddWithValue("@MesaiBaslangicSaati", MesaiBaslangicSaati);
                        cmd.Parameters.AddWithValue("@MesaiBitisSaati", MesaiBitisSaati);
                        cmd.Parameters.AddWithValue("@Maas", Maas);
                        cmd.Parameters.AddWithValue("@SaatlikUcret", SaatlikUcret);
                        cmd.Parameters.AddWithValue("@subeID", subeID); // SubeID parametresi
                        cmd.Parameters.AddWithValue("@PersonelID", personelID); // PersonelID'yi güncelleme sorgusuna ekliyoruz

                        // Komutu çalıştır ve etkilenen satır sayısını al
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Personel verileri başarıyla güncellendi!");  // Güncelleme başarılı
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek veriler bulunamadı.");  // Güncellenemezse hata mesajı
                        }
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