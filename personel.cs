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
            // TextBox'lardan verileri alıyoruz
            string Isim = textBox1.Text;
            string Soyisim = textBox2.Text;
            string Pozisyon = textBox3.Text;
            string MesaiBaslangicSaati = textBox4.Text;
            string MesaiBitisSaati = textBox5.Text;
            string Maas = textBox6.Text;
            string SaatlikUcret = textBox7.Text;
            string SubeID = textBox8.Text;

            // DataTable'a yeni satır ekliyoruz
            personelTable.Rows.Add(Isim, Soyisim, Pozisyon, MesaiBaslangicSaati, MesaiBitisSaati, SaatlikUcret, Maas, SubeID);

            // TextBox'ları temizliyoruz (isteğe bağlı)
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
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
    }
}
