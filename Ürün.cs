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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    public partial class Ürün : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        private DataTable ÜrünTable;
        public Ürün()
        {
            InitializeComponent();
            // Personel tablosu ve DataGridView'e veri kaynağını bağlamak
            ÜrünTable = new DataTable();

            // DataTable'a sütunları ekliyoruz
            ÜrünTable.Columns.Add("ürünAdi", typeof(string));
            ÜrünTable.Columns.Add("ürünMarka", typeof(string));
            ÜrünTable.Columns.Add("ürünFiyati", typeof(string));
            ÜrünTable.Columns.Add("ürünTipi", typeof(string));
            ÜrünTable.Columns.Add("stokMiktari", typeof(string));
           

            // DataGridView'e veri kaynağını bağlıyoruz
            dataGridView1.DataSource = ÜrünTable;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ürün_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet9.ürün' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTableAdapter1.Fill(this.petrol_otomasyonDataSet9.ürün);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet3.ürün' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTableAdapter.Fill(this.petrol_otomasyonDataSet3.ürün);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // TextBox'lardan verileri alıyoruz
            string ürünAdi = textBox1.Text;
            string ürünMarka = textBox2.Text;
            string ürünFiyati = textBox3.Text;
            string ürünTipi = textBox4.Text;
            string stokMiktari = textBox5.Text;


            // DataTable'a yeni satır ekliyoruz
            ÜrünTable.Rows.Add(ürünAdi, ürünMarka, ürünFiyati, ürünTipi, stokMiktari);

            // TextBox'ları temizliyoruz (isteğe bağlı)
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchText = textBox6.Text; // TextBox9'dan alınan arama metni
            AramaYap(searchText);
        }
        private void AramaYap(string searchText)
        {
            string isim = textBox6.Text;

            try
            {
                // SQL sorgusunu oluşturuyoruz
                string sorgu = "SELECT * FROM ürün WHERE ürünAdi LIKE @isim";
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
    }
    
}
